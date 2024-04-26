namespace ReecritureDeCodeProprietesEncapsulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Encapsulation
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                //House house = new House();
                //Room room = new Room();
                //Door houseDoor = new Door();
                //Door roomDoor = new Door();
                //house.AddDoor(houseDoor);
                //room.AddDoor(roomDoor);
                //house.AddRoom(room);

                try
                {
                    // Création d'objets type Door
                    List<Door> doors = new List<Door>()
                    {
                      new Door(),
                      new Door(),
                      new Door()
                    };

                    // Creation de quelques objets spécifiques frontDoor et bedroomDoor
                    Door frontDoor = doors[0];
                    Door bedroomDoor = doors[1];

                    // Création des objets de type Room
                    List<Room> rooms = new List<Room>()
                    {
                      new Room(doors.Take(2).ToList()), // affectation des deux premiers objets de type Door au premier objet Room
                      new Room(doors.Skip(2).ToList()) // affectation des objets de type Door restants au deuxième objet de type Room
                    };

                    // Création (instanciation) d'un objet myHouse de type House avec la liste préparée
                    House myHouse = new House(rooms, doors);

                    // Appliquer les méthodes Open et Close à certains objets de type Door
                    frontDoor.Open(); 
                    bedroomDoor.Close();

                    Console.WriteLine("House created and doors managed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred: {0}", ex.Message);
                }

            }
        }
        // Réécriture de la classe House
        public class House
        {
            //Ancienne déclaration avec des attributs
           //public List<Room> _rooms;
           //public List<Door> _doors;

            //Nouvelle déclaration avec des propriétés 
            public List<Room> Rooms {get; set;}
            public List<Door> Doors { get; set;}

            //Ancienne déclaration du constructeur de la classe House
            /* public House()
           {
               _rooms = new List<Room>();
               _doors = new List<Door>();
           }*/

            //Nouvelle déclaration du constructeur de la classe House avec les propriétés
            public House(List<Room> rooms, List<Door> doors)
            {
                Rooms = rooms;
                Doors = doors;
            }

          
            //réécriture des méthodes AddDoor et AddRoom
            //Ancienne écriture des méthodes
            /*public void AddDoor(Door door)
            {
                _doors.Add(door);
            }

            public void AddRoom(Room room)
            {
                _rooms.Add(room);
            }*/

            public void AddDoor(Door door)
            {
                Doors.Add(door);
            }

            public void AddRoom(Room room)
            {
                Rooms.Add(room);
            }
        }

        public class Room
        {
            //Ancienne écriture
            public List<Door> _doors;

            //Nouvelle écriture
            public List<Door> Doors { get; set; }

            //Ancienne écriture
            /*public Room()
            {
                _doors = new List<Door>();
            }*/

            //Nouvelle écriture
            public Room(List<Door> doors)
            {
                Doors = doors;
            }

            //Ancienne écriture
            /*public void AddDoor(Door door)
            {
                _doors.Add(door);
            }*/

            //Nouvelle écriture
            public void AddDoor(Door door)
            {
                Doors.Add(door);
            }

        }

        public class Door
        {
            //Ancienne écriture
            //public bool _isOpen;

            //Nouvelle écriture
            public bool IsOpen { get; private set; }

            public Door()
            {
                //Ancienne écriture
                //_isOpen = false;

                //Nouvelle écriture
                IsOpen = false;
            }

            //Ancienne écriture de la méthode Open
            /* public void Open()
             {
                 if (_isOpen)
                 {
                     Console.WriteLine("Door already opened. Ain't done anything.");
                 }
                 else
                 {
                     _isOpen = true;
                 }
             }*/

            public void Open()
            {
                if (IsOpen)
                {
                    Console.WriteLine("Door already opened. Ain't done anything.");
                }
                else
                {
                    IsOpen = true;
                }
            }

            //Ancienne écriture de la méthode close
            /* public void Close()
             {
                 if (!_isOpen)
                 {
                     Console.WriteLine("Door already closed. Ain't done anything.");
                 }
                 else
                 {
                     _isOpen = false;
                 }
             }*/

            //Nouvelle écriture de la méthode
            public void Close()
            {
                if (!IsOpen)
                {
                    Console.WriteLine("Door already closed. Ain't done anything.");
                }
                else
                {
                    IsOpen = false;
                }
            }
        }
    }
}
