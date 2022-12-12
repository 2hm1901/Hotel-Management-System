namespace Hotel_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create Hotel
            RoomInHotel room = new RoomInHotel();
            room.AddTypeRoom();

            Customer customer = new Customer();

            int choice;
            do
            {
                choice = Menu.EnterUserChoice();
                switch (choice)
                {
                    case 1:
                        customer.InputInforCustomer();
                        break;
                    case 2:                       
                        room.CheckRoom(room, customer.Request);
                        room.ConfirmRent(room, customer.Name, customer.Time);
                        break;
                    case 3:
                        room.DisplayInfor(room);
                        break;
                    case 4:
                        room.DisplayBill(room);
                        break;
                    case 5:
                        Console.WriteLine("Thanks for using");
                        break;
                    default:
                        Console.WriteLine("Errnor!");
                        break;
                }
            } while (choice != 5);    
        }
    }
}