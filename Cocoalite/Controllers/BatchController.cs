using System;
using System.Data;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    public class BatchController
    {
        private readonly BatchContext _context = new BatchContext();

        public DataTable GetApprovedQc()
        {
            DataTable data = _context.GetApprovedQc();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public DataTable GetAllBatch()
        {
            DataTable data = _context.GetAllBatch();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public void AddBatch(
     int qcId,
     string batchCode,
     DateTime batchDate, // Parameter dari Form tetap DateTime agar tidak merusak UI
     decimal batchWeight,
     string batchStatus)
        {
            Batch batch = new Batch();

            batch.QcId = qcId;
            batch.BatchCode = batchCode;

            // ✨ JALAN KELUAR: Ubah DateTime menjadi DateOnly secara natural di sini
            batch.BatchDate = DateOnly.FromDateTime(batchDate);

            batch.BatchWeight = batchWeight;
            batch.BatchStatus = "Available";

            _context.InsertBatch(batch);
        }

        public void UpdateBatch(
            int batchId,
            int qcId,
            string batchCode,
            DateTime batchDate, // Parameter tetap DateTime
            decimal batchWeight,
            string batchStatus)
        {
            if (batchId <= 0)
            {
                throw new ArgumentException("ID batch tidak valid.");
            }

            Batch batch = new Batch();

            batch.BatchId = batchId;
            batch.QcId = qcId;
            batch.BatchCode = batchCode;

            // ✨ JALAN KELUAR: Lakukan hal yang sama untuk proses Update
            batch.BatchDate = DateOnly.FromDateTime(batchDate);

            batch.BatchWeight = batchWeight;
            batch.BatchStatus = batchStatus;

            _context.UpdateBatch(batch);
        }
        public void DeleteBatch(int batchId)
        {
            if (batchId <= 0)
            {
                throw new ArgumentException("ID batch tidak valid.");
            }

            _context.DeleteBatch(batchId);
        }
    }
}