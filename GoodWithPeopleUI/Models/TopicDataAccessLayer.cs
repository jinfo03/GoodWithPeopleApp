using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodWithPeopleMainUI.Models
{
    public class TopicDataAccessLayer
    {

        private readonly GoodWithPeopleDBContext db = new GoodWithPeopleDBContext();

        public IEnumerable<Topic> GetAllTopics()
        {
            try
            {
                return db.Topic.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new Topic record     
        public int AddTopic(Topic topic)
        {
            try
            {
                db.Topic.Add(topic);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar topic    
        public int UpdateTopic(Topic topic)
        {
            try
            {
                db.Entry(topic).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular topic    
        public Topic GetTopicData(int id)
        {
            try
            {
                Topic topic = db.Topic.Find(id);
                return topic;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular topic    
        public int DeleteTopic(int id)
        {
            try
            {
                Topic emp = db.Topic.Find(id);
                db.Topic.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
