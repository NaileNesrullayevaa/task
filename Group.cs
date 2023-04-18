using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Group
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; } 
        public Group(string name)
        {
            _id++;
            Id= _id;
            Name = name;
        }

        public void CreateGroup()
        {
            Group group = new Group("");
            string Name1=Console.ReadLine();
            int Id1=int.Parse(Console.ReadLine());
            
            group.Name=Name1;
            group.Id=Id1;
        }
        public void DeleteGroup()
        {
            
            int Id1=int.Parse(Console.ReadLine());
            Group groups = Groups.Find(group => group.Id == Id1);
            Groups.Remove(groups);
            
            
            

        }
        public void UpdateGroup()
        {
            int Id1 = int.Parse(Console.ReadLine());
            Group groups = Groups.Find(group => group.Id == Id1);
            string name=Console.ReadLine();
            groups.Name = name;

        }
        public void showallGroup()
        {
            foreach(var item in Groups)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
