using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjKpopIndexers
{
    public class Groups
    {
        public int numOfMembers, numSongs;
       
        private string groupName, gender,popSong;

        public Groups(string groupName, string gender, int numOfMembers, int numSongs, string popSong)
        {

            this.groupName = groupName;
            this.gender = gender;
            this.numOfMembers = numOfMembers;
            this.numSongs = numSongs;
            this.popSong = popSong;


        }

        //First indexer, allows access using intergers
        public object this[int index]
        {
            get
            {
                if (index == 0)

                    return this.groupName; //returns value based on index
                else if (index == 1)

                    return this.gender;

                else if (index == 2)

                    return this.numOfMembers;

                else if (index == 3)

                    return this.numSongs;

                else if (index == 4)

                    return this.popSong;
                return null;
            }
            set
            {
                if (index == 0)
                    this.groupName = (string)value;//sets value based on index
                else if (index == 1)
                    this.gender = (string)value;
                else if (index == 2)
                    this.numOfMembers = (int)value;
                else if (index == 3)
                    this.numSongs = (int)value;
                else if (index == 4)
                    this.popSong = (string)value;
            }

        }
        //Second indexer, user string index, attribute names
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("name"))
                    return this.groupName;
                else if (attrName.ToLower().Equals("gender"))
                    return this.gender;
                else if (attrName.ToLower().Equals("members"))
                    return this.numOfMembers;
                else if (attrName.ToLower().Equals("songs"))
                    return this.numSongs;
                else if (attrName.ToLower().Equals("popularSong"))
                    return this.popSong;
                return null;
                //looks at attribute name, converted to lowe case and returns matching value
            }
            set
            {
                if (attrName.ToLower().Equals("name"))
                    this.groupName = (string)value;
                else if (attrName.ToLower().Equals("gender"))
                    this.gender = (string)value;
                else if (attrName.ToLower().Equals("members"))
                    this.numOfMembers = (int)value;
                else if (attrName.ToLower().Equals("songs"))
                    this.numSongs = (int)value;
                else if (attrName.ToLower().Equals("popularSong"))
                    this.popSong = (string)value;
            }
        }
    }
}
