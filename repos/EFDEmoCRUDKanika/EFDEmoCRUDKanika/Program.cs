﻿using EFDEmoCRUDKanika.Models;

namespace EFDEmoCRUDKanika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BatchDbContext db = new BatchDbContext();
            // insert record
            //Batch batch = new Batch()
            //{ Name = "B003", Description = "", StartDate = Convert.ToDateTime("12/12/2022") };
            //db.Batches.Add(batch);
            //db.SaveChanges();

            ////delete record
            //Batch b = db.Batches.Where(x =>
            //x.Id == 1).FirstOrDefault();
            //if (b != null)
            //{
            //    db.Batches.Remove(b);
            //    db.SaveChanges();
            //}
            //else
            //    Console.WriteLine("there is no record");

            //Edit Record

            Batch bobj = db.Batches.Where(x => x.Id == 2)
                   .FirstOrDefault();

            if (bobj != null)
            {
                foreach (Batch temp in db.Batches)
                {
                    if (temp.Id == bobj.Id)
                    {
                        temp.StartDate = Convert.ToDateTime(DateTime.Now);
                        temp.Description = "its a new batch";
                    }


                }
                db.SaveChanges();
            }
            else
                Console.WriteLine("There is no record");

            // List of Records
            //List<Batch> list = new List<Batch>();
            //list = db.Batches.ToList();
            //foreach (Batch temp in list)
            //{
            //    Console.WriteLine($"{temp.Id} -- {temp.Name} -- {temp.Description} -- {temp.StartDate}");
            //}
        }
    }
}