using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_practice
{
    internal class demo8
    {
        static void Main1(String[] args)
        {
            KDACStudent student = new KDACStudent();
            student.Name = "Mohit";

            ProposalHandler parag = new ProposalHandler(onProposalAcceptGoToAlankar);
            ProposalHandler pranjal = new ProposalHandler(onProposalRejectedGoToDhapata);

            student.ProposalAccepted += parag;
            student.ProposalRejected += pranjal;

            Console.WriteLine("Kya hain?");

            student.Propose(Console.ReadLine());    

             Console.ReadLine();    
        }

        public static void onProposalAcceptGoToAlankar()
        {
            Console.WriteLine("Happy party");
        }
        public static void onProposalRejectedGoToDhapata()
        {
            Console.WriteLine("Sad Party");
        }
    }

    public delegate void ProposalHandler ();
    public class KDACStudent
    {
        public event ProposalHandler ProposalAccepted;
        public event ProposalHandler ProposalRejected;

        private String _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void Propose(String message)
        {
            if (message == "I am mohit")
                ProposalRejected();
            else
                ProposalAccepted();
        }

    }
}
