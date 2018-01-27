using System;
using System.Collections.Generic;
namespace Institute
{
    class Courses
    {
        string name;
        Teacher t = null;
        protected List<string> topic = new List<string>();

        public string Name
        {
            set{ this.name = value; }
            get{ return this.name; }
        }
        public void SetTeacher(Teacher t)
        {
            this.t = t;
        }
        public string GetTeacher()
        {
            return this.t.Name;
        }
        public void AddTopic(string topic)
        {
            this.topic.Add(topic);
        }
    }
}
