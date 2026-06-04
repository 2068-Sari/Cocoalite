using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class QualityControlContext
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetAllQualityControl()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT qc.qc_id,  r.receiving_code, qc.receiving_id, qc.moisture_level, qc.fermentation_level, qc.defect_level,
                        qc.bean_size, qc.grade,  qc.qc_status, qc.inspection_notes, qc.inspected_by, qc.inspected_at
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

        public DataTable GetAllReceiving()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT receiving_id,  receiving_code
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

        public string DetermineGrade(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT determine_grade(@moisture, @fermentation, @defect)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@moisture", moistureLevel);
                    cmd.Parameters.AddWithValue("@fermentation", fermentationLevel);
                    cmd.Parameters.AddWithValue("@defect", defectLevel);

                    object? result = cmd.ExecuteScalar();

                    return result?.ToString() ?? "Reject";
                }
            }
        }

        public void InsertQualityControl(QualityControl qc)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                    INSERT INTO quality_control
                    ( receiving_id, moisture_level, fermentation_level, defect_level, bean_size,
                        grade, qc_status, inspection_notes, inspected_by, inspected_at
                    )
                    VALUES
                    ( @receiving_id, @moisture_level,  @fermentation_level, @defect_level,@bean_size,
                        @grade,@qc_status, @inspection_notes, @inspected_by, @inspected_at
                    )";

                        using (var cmd = new NpgsqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@receiving_id", qc.ReceivingId);
                            cmd.Parameters.AddWithValue("@moisture_level", qc.Parameter.MoistureLevel);
                            cmd.Parameters.AddWithValue("@fermentation_level", qc.Parameter.FermentationLevel);
                            cmd.Parameters.AddWithValue("@defect_level", qc.Parameter.DefectLevel);
                            cmd.Parameters.AddWithValue("@bean_size", qc.Parameter.BeanSize);
                            cmd.Parameters.AddWithValue("@grade", qc.Grade);
                            cmd.Parameters.AddWithValue("@qc_status", qc.QcStatus);
                            cmd.Parameters.AddWithValue("@inspection_notes", qc.InspectionNotes);
                            cmd.Parameters.AddWithValue("@inspected_by", qc.InspectedBy);
                            cmd.Parameters.AddWithValue("@inspected_at", qc.InspectionDate);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdateQualityControl(QualityControl qc)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE quality_control
                    SET
                        receiving_id = @receiving_id,
                        moisture_level = @moisture_level,
                        fermentation_level = @fermentation_level,
                        defect_level = @defect_level,
                        bean_size = @bean_size,
                        grade = @grade,
                        qc_status = @qc_status,
                        inspection_notes = @inspection_notes,
                        inspected_by = @inspected_by,
                        inspected_at = @inspected_at
                    WHERE qc_id = @qc_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qc_id", qc.QcId);
                    cmd.Parameters.AddWithValue("@receiving_id", qc.ReceivingId);
                    cmd.Parameters.AddWithValue("@moisture_level", qc.Parameter.MoistureLevel);
                    cmd.Parameters.AddWithValue("@fermentation_level", qc.Parameter.FermentationLevel);
                    cmd.Parameters.AddWithValue("@defect_level", qc.Parameter.DefectLevel);
                    cmd.Parameters.AddWithValue("@bean_size", qc.Parameter.BeanSize);
                    cmd.Parameters.AddWithValue("@grade", qc.Grade);
                    cmd.Parameters.AddWithValue("@qc_status", qc.QcStatus);
                    cmd.Parameters.AddWithValue("@inspection_notes", qc.InspectionNotes);
                    cmd.Parameters.AddWithValue("@inspected_by", qc.InspectedBy);
                    cmd.Parameters.AddWithValue("@inspected_at", qc.InspectionDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteQualityControl(int qcId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    DELETE FROM quality_control
                    WHERE qc_id = @qc_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qc_id", qcId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}