using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class QualityControlController
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetReceiving()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT receiving_id, receiving_code
                    FROM receiving
                    ORDER BY receiving_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public DataTable GetAllQualityControl()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        qc.qc_id,
                        r.receiving_code,
                        qc.moisture_level,
                        qc.fermentation_level,
                        qc.defect_level,
                        qc.bean_size,
                        qc.grade,
                        qc.qc_status,
                        qc.inspection_notes,
                        qc.inspection_date
                    FROM quality_control qc
                    JOIN receiving r ON qc.receiving_id = r.receiving_id
                    ORDER BY qc.qc_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public string DetermineGrade(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT determine_grade(
                @moisture_level,
                @fermentation_level,
                @defect_level
            )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@moisture_level", moistureLevel);
                    cmd.Parameters.AddWithValue("@fermentation_level", fermentationLevel);
                    cmd.Parameters.AddWithValue("@defect_level", defectLevel);

                    object? result = cmd.ExecuteScalar();

                    return result?.ToString() ?? "Reject";
                }
            }
        }
        public void AddQualityControl(
            int receivingId,
            int inspectedBy,
            decimal moisture,
            decimal fermentation,
            decimal defect,
            string beanSize,
            string qcStatus,
            string notes,
            DateTime inspectionDate)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string gradeQuery = @"
            SELECT determine_grade(
                @moisture,
                @fermentation,
                @defect
            )";

                string grade;

                using (var gradeCmd = new NpgsqlCommand(gradeQuery, conn))
                {
                    gradeCmd.Parameters.AddWithValue("@moisture", moisture);
                    gradeCmd.Parameters.AddWithValue("@fermentation", fermentation);
                    gradeCmd.Parameters.AddWithValue("@defect", defect);

                    grade = gradeCmd.ExecuteScalar()?.ToString() ?? "Reject";
                }

                string query = @"
            INSERT INTO quality_control
            ( 
              receiving_id, inspected_by, moisture_level, fermentation_level, defect_level, bean_size, 
              grade,qc_status, inspection_notes, inspection_date
            )
            VALUES
            (
                @receivingId, @inspectedBy, @moisture, @fermentation, @defect, @beanSize,
                @grade, @qcStatus, @notes, @inspectionDate
            )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receivingId", receivingId);
                    cmd.Parameters.AddWithValue("@inspectedBy", inspectedBy);
                    cmd.Parameters.AddWithValue("@moisture", moisture);
                    cmd.Parameters.AddWithValue("@fermentation", fermentation);
                    cmd.Parameters.AddWithValue("@defect", defect);
                    cmd.Parameters.AddWithValue("@beanSize", beanSize);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@qcStatus", qcStatus);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@inspectionDate", inspectionDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateQualityControl(
            int qcId,
            int receivingId,
            decimal moisture,
            decimal fermentation,
            decimal defect,
            string beanSize,
            string qcStatus,
            string notes,
            DateTime inspectionDate)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string gradeQuery = @"
            SELECT determine_grade(
                @moisture,
                @fermentation,
                @defect
            )";

                string grade;

                using (var gradeCmd = new NpgsqlCommand(gradeQuery, conn))
                {
                    gradeCmd.Parameters.AddWithValue("@moisture", moisture);
                    gradeCmd.Parameters.AddWithValue("@fermentation", fermentation);
                    gradeCmd.Parameters.AddWithValue("@defect", defect);

                    grade = gradeCmd.ExecuteScalar()?.ToString() ?? "Reject";
                }

                string query = @"
            UPDATE quality_control
            SET
                receiving_id = @receivingId,
                moisture_level = @moisture,
                fermentation_level = @fermentation,
                defect_level = @defect,
                bean_size = @beanSize,
                grade = @grade,
                qc_status = @qcStatus,
                inspection_notes = @notes,
                inspection_date = @inspectionDate
            WHERE qc_id = @qcId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qcId", qcId);
                    cmd.Parameters.AddWithValue("@receivingId", receivingId);
                    cmd.Parameters.AddWithValue("@moisture", moisture);
                    cmd.Parameters.AddWithValue("@fermentation", fermentation);
                    cmd.Parameters.AddWithValue("@defect", defect);
                    cmd.Parameters.AddWithValue("@beanSize", beanSize);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@qcStatus", qcStatus);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@inspectionDate", inspectionDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteQualityControl(int qcId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM quality_control WHERE qc_id = @qcId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qcId", qcId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}