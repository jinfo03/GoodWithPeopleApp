using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoodWithPeopleMainUI.Models
{
    public class NoteDataAccessLayer
    {

        private readonly GoodWithPeopleDBContext db = new GoodWithPeopleDBContext();

    public IEnumerable<Note> GetAllNotes()
    {
        try
        {
            return db.Note.ToList();
        }
        catch
        {
            throw;
        }
    }
    //To Add new note record     
    public int AddNote(Note note)
    {
        try
        {
            db.Note.Add(note);
            db.SaveChanges();
            return 1;
        }
        catch
        {
            throw;
        }
    }
    //To Update the records of a particluar note    
    public int UpdateNote(Note note)
    {
        try
        {
            db.Entry(note).State = EntityState.Modified;
            db.SaveChanges();
            return 1;
        }
        catch
        {
            throw;
        }
    }
    //Get the details of a particular note    
    public Note GetNoteData(int id)
    {
        try
        {
            Note note = db.Note.Find(id);
            return note;
        }
        catch
        {
            throw;
        }
    }
    //To Delete the record of a particular note    
    public int DeleteNote(int id)
    {
        try
        {
            Note emp = db.Note.Find(id);
            db.Note.Remove(emp);
            db.SaveChanges();
            return 1;
        }
        catch
        {
            throw;
        }
    }
    //To Get the list of Persons    
    public List<Person> GetPersons()
    {
        List<Person> lstPerson = new List<Person>();
        lstPerson = (from PersonList in db.Person select PersonList).ToList();
        return lstPerson;
        }
        //To Get the list of topics    
        public List<Topic> GetTopics()
        {
            List<Topic> lstTopic = new List<Topic>();
            lstTopic = (from TopicList in db.Topic select TopicList).ToList();
            return lstTopic;
        }
    }  
}
