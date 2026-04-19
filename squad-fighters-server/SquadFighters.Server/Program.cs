using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadFighters.Server {
    class Program {
        static void Main(string[] args) {

            //יצירת סרבר:
            Server server = new Server("127.0.0.1", 7895);

            //התחלת השרת:
            server.Start();
        }
    }
}
