using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participants
{
    class Students
    {
    	string givenName;
    	string sirName;

    	public string GivenName { get{return givenName;} set{givenName = value;} }
    	public string SirName { get => sirName; set => sirName = value; }
    	public string StudentId { get; set; }
    	public string Auid { get; set; }


        
    }
}
