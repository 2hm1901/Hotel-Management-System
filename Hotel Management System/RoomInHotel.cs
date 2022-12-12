﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class RoomInHotel
    {
        public List<Room> roomList = new List<Room>();
        public void AddTypeRoom()
        {
            Room room1 = new Room();
            room1.Type = "Standard";
            roomList.Add(room1);

            Room room2 = new Room();
            room2.Type = "Standard";
            roomList.Add(room2);

            Room room3 = new Room();
            room3.Type = "Standard";
            roomList.Add(room3);

            Room room4 = new Room();
            room4.Type = "Vip";
            roomList.Add(room4);

            Room room5 = new Room();
            room5.Type = "Vip";
            roomList.Add(room5);

            Room room6 = new Room();
            room6.Type = "Vip";
            roomList.Add(room6);

            Room room7 = new Room();
            room7.Type = "Family";
            roomList.Add(room7);

            Room room8 = new Room();
            room8.Type = "Family";
            roomList.Add(room8);

            Room room9 = new Room();
            room9.Type = "Family";
            roomList.Add(room9);
        }
        public bool CheckStatus(RoomInHotel rooms, int i)
        {
            bool tmp = false;

            if (roomList[i].Name == null)
            {
                tmp = true;
            }
            return tmp;
        }
        public void CheckRoom(RoomInHotel rooms, string request)
        {
            Console.WriteLine("<<Rooms that match customer requirements are still available>>");
            for (int i = 0; i < roomList.Count; i++)
            {
                if (string.Compare(request, roomList[i].Type) == 0)
                {
                    bool check = CheckStatus(rooms, i);
                    if (check==true)
                    {                       
                        Console.WriteLine($"{roomList[i].Type} Room {i+1} is available");
                    }
                }                                                           
            }
        }
        public void ConfirmRent(RoomInHotel rooms, string name, int time)
        {
            Console.Write("What is Room You Want to Rent: ");
            int roomNumber = int.Parse(Console.ReadLine());
            roomList[roomNumber - 1].Name = name;
            roomList[roomNumber - 1].Time = time;

            Console.WriteLine($"{roomList[roomNumber - 1].Type} Room {roomNumber} is Rented Now By Mr. {roomList[roomNumber-1].Name}");
        }
        public void DisplayInfor(RoomInHotel rooms)
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                bool check = CheckStatus(rooms, i);
                if (check == true)
                {
                    Console.WriteLine($"{roomList[i].Type} Room {i + 1} is available");
                }
                else if (check == false)
                {
                    Console.WriteLine($"{roomList[i].Type} Room {i+1} is rented by Mr. {roomList[i].Name} in {roomList[i].Time} Days");
                }
            }
        }
        public int PriceRoom(RoomInHotel rooms, int roomNumber)
        {
            int price=0;
            if (roomList[roomNumber-1].Type == "Standard")
            {
                price = 200;
            }
            else if (roomList[roomNumber - 1].Type == "Vip")
            {
                price = 400;
            }
            else
            {
                price = 300;
            }
            return price;

        }
        public void DisplayBill(RoomInHotel rooms)
        {
            Console.Write("Pay for the room: ");
            int roomNumber = int.Parse(Console.ReadLine());
            int bill = roomList[roomNumber-1].Time * PriceRoom(rooms, roomNumber);
            Console.WriteLine($"You will cost {bill}$ for rented {roomList[roomNumber-1].Type} room in {roomList[roomNumber-1].Time} days");
            roomList[roomNumber - 1].Name = null;
        }
    }
}