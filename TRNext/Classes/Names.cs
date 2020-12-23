using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Random name generator class
     */
    class Names
    {
        private string[] names = {
            "JUAN",
            "JOSÉ LUIS",
            "JOSÉ",
            "MARÍA GUADALUPE",
            "FRANCISCO",
            "GUADALUPE",
            "MARÍA",
            "JUANA",
            "ANTONIO",
            "JESÚS",
            "MIGUEL ÁNGEL",
            "PEDRO",
            "ALEJANDRO",
            "MANUEL",
            "MARGARITA",
            "MARÍA DEL CARMEN",
            "JUAN CARLOS",
            "ROBERTO",
            "FERNANDO",
            "DANIEL",
        };

        public Names() { }

        public string generateName()
        {
            var rand = new Random();

            return this.names[rand.Next(19)];
        }
    }
}
