using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class RoomServices
    {
        //List of rooms
        public List <Room> Rooms { get; set; }

        int currentRoom = 1;

        public RoomServices()
        {
            Rooms = new List<Room>
            {
                new Room(1, "Beach", "You walk up on the beach, standing at the edge of the water. You feel the waves wash over you feet.",
                new List<Item>
                {
                    new Weapon(1, "Wooden stick", "A worn down drenched piece of wood.", 5, false, 2)
                }, null,
                2, -1, -1, -1),
                
                new Room(2, "Low waters", "You're knee deep in the water now. You're blankly staring into your own reflection in the ocean waters.",
                new List<Item>
                {
                    
                }, new Monster(1, "Jellyfish", "You see a jellyfish being carried by the waves, floating uselessly. End it's miserable existence.", "It continues to sway to the rhythm of the waves", "There was no reaction but you got a hit on it.", 10, false, 0),
                3, 1, -1, -1),

                new Room(3, "Coral reef", "You enter and meet a world of colors. There's corals as far as you can see.\nYou feel yourself soothed by the sight.",
                new List<Item>
                {
                    new Potion(1, "ATK potion", "A potion that will boost your currently equipped gear for the next [5] attacks by 2x!", "Damage", 2, 0, 1),
                    new Weapon(2, "Knife", "", 20, false, 5)
                }, null,
                6, 2, 4, 5),

                new Room(4, "Glowing algae cave", "You dove towards a small creek of light. You were met with a big cave full of glowing algae.\nYou felt a sense of comfort in this place.",
                new List<Item>
                {
                    new Potion(2, "HP potion", "A potion that heals player by 50+ HP.", "Healing", 0, 50, 1)
                }, null,
                7, -1, -1, 3),

                new Room(5, "Seaweed forest", "You've entered a forest of seaweed.\nYou feel it all closing in on you and the restrains of slowly getting entackled in it's ropes.\nYou don't wanna stay too long.",
                new List<Item>
                {

                }, new Monster(2, "Eel", "Yikes! you see an eerie eel slithering towards you!", "It sends an electrical impuls into the surrounding water and hurts you", "ouch", 50, false, 10),
                8, -1, 3, -1),

                new Room(6, "Starfish mountains", "You're towered by tall rocks all around you.\nThe rocks are spotted with starfish, covering it all over",
                new List<Item>
                {

                }, null,
                9, 3, 7, 8),

                new Room(7, "Red shark seas", "You swam forward and suddenly found yourself in a swarm of blood thirsty sharks! You gotta get a break through them.",
                new List<Item>
                {
                    new Weapon(3, "Harpoon", "", 120, true, 10)
                }, new Monster(3, "Shark", "", "", "", 200, true, 125),
                -1, 4, -1, 6),

                new Room(8, "Sunken ship", "A sunken ship lies before you. There's a gabbing hole where it was hit. It seems risky to cram yourself through but you must explore the depths.",
                new List<Item>
                {
                    new Weapon(4, "Cannon balls", "", 80, true, 3)
                }, null,
                -1, 5, 6, -1),

                new Room(9, "Deep dark ocean", "You swim deeper, as the light is fading you feel a sense of dread and emptiness. Is it a good idea to go on?",
                new List<Item>
                {

                }, null,
                10, 6, -1, -1),

                new Room(10, "King crab gates", "",
                new List<Item>
                {

                }, new Monster(4, "Guardian crab", "", "", "", 50, false, 50),
                11, 9, -1, -1),

                new Room(11, "King crab lair", "",
                new List<Item>
                {

                }, new Monster(5, "King crab", "", "", "", 200, false, 20),
                -1, 10, -1, -1),
            };
        }

        //Gets room by it's id
        public Room GetRoomById(int roomId)
        {
            return Rooms.Find(room => room.Id == roomId);
        }

        //Prints room and it's items
        public void GoToRoom(int roomId)
        {
            currentRoom = roomId;
            Room room = GetRoomById(roomId);

            if (room.Monster != null)
            {
                bool victory = Fight(room.Monster);

                if (victory)
                {
                    Console.WriteLine("\nYou won the battle!\n");
                    room.Monster = null;
                }
                else
                {
                    Console.WriteLine("GAME OVER!");
                    return;
                }
            }

            Console.WriteLine("[{0}]\n", room.Name);
            Console.WriteLine(room.Description);

            if (room.Items.Count > 0)
            {
                Console.Write("\nYou spot some things in the area:\n");
            }

            for (int i = 0; i < room.Items.Count; i++)
            {
                Console.Write("{0}. {1}\n", i + 1, room.Items[i].Name);
            }

            Console.Write("\nDirections available can go:\n");

            //Printing room direction options
            if (room.North != -1)
            {
                Console.WriteLine("North [N]");
            }
            if (room.South != -1)
            {
                Console.WriteLine("South [S]");
            }
            if (room.East != -1)
            {
                Console.WriteLine("East [E]");
            }
            if (room.West != -1)
            {
                Console.WriteLine("West [W]");
            }

            //Taking user input and allowing to move between rooms
            Console.WriteLine("\nCommand options:\n1. Go [Direction]\n2. Pickup [Item]\n3. Inventory\n");
            Console.WriteLine("");
            string playerInput = Console.ReadLine();

            List<string> arguments = playerInput.Split(' ').ToList();
            string command = arguments[0];
            arguments.RemoveAt(0);

            switch (command.ToLower())
            {
                case "go":

                    string direction = arguments[0].ToUpper();

                    Console.Clear();
                    if (direction == "N" && room.North != -1)
                    {
                        GoToRoom(room.North);
                    }

                    else if (direction == "S" && room.South != -1)
                    {
                        GoToRoom(room.South);
                    }

                    else if (direction == "E" && room.East != -1)
                    {
                        GoToRoom(room.East);
                    }

                    else if (direction == "W" && room.West != -1)
                    {
                        GoToRoom(room.West);
                    }

                    break;

                //Pick up item //Add to player
                case "pickup":
                    string itemName = string.Join(" ", arguments);
                    Item? item = FindItemByName(itemName, currentRoom);

                    if(item != null)
                    {
                        RemoveItemFromRoom(room, item);
                        Player.AddItem(item);
                    }

                    Console.Clear();
                    Console.WriteLine($"You picked up {item.Name}! \n");
                    GoToRoom(currentRoom);

                    break;

                //Show player inventory
                case "inventory":
                    Console.Clear();
                    Console.WriteLine("Inventory: ");
                    for (int i = 0; i < Player.Inventory.Count; i++)
                    {
                        Console.Write("{0}. {1} - {2}\n", i + 1, Player.Inventory[i].Name, Player.Inventory[i].Description);
                    }
                    Console.WriteLine();
                    GoToRoom(currentRoom);

                    break;

                default:
                    break;
            }
        }

        //Find item by name
        public Item? FindItemByName(string itemName, int roomId)
        {
            itemName = itemName.ToLower();
            Room? room = GetRoomById(roomId);

            foreach (Item item in room.Items)
            {
                if (item.Name.ToLower() == itemName)
                {
                    return item;
                }
            }
            return null;
        }

        //Remove item from room
        public void RemoveItemFromRoom(Room room, Item item)
        {
            room.Items.Remove(item);
        }

        public bool Fight(Monster monster)
        {
            int battleStart = 0;

            while (monster.Health > 0) 
            {

                if (battleStart == 1)
                {
                    Console.WriteLine("\nCommand options:\n1. Attack\n2. Inventory\n3. Equip [Weapon]\n4. Use [Item]");
                }

                if (battleStart == 0)
                {
                    Console.WriteLine(monster.Intro + "\n");
                    Console.WriteLine("You've now entered battle!!!");
                    Console.WriteLine("\nCommand options:\n1. Attack\n2. Inventory\n3. Equip [Weapon]\n4. Use [Item]");
                    battleStart = 1;
                }

                bool usedTurn = false;
                while (!usedTurn)
                {
                    Console.WriteLine();
                    string playerInput = Console.ReadLine();

                    List<string> arguments = playerInput.Split(' ').ToList();
                    string command = arguments[0];
                    arguments.RemoveAt(0);

                    Console.Clear();
                    switch (command.ToLower())
                    {
                        case "attack":
                            if (Player.EquippedWeapon != null)
                            {
                                if (!monster.Resistance)
                                {
                                    if (Player.StatusEffects.Count == 0) //This shit is hard... no instance? no reference?? kms
                                    {
                                        monster.TakeDamage(Player.EquippedWeapon.Damage);
                                    }
                                    else if (Player.StatusEffects.Count != 0 && Player.PotionEffects.StatusEffect > 0)
                                    {
                                        monster.TakeDamage(Player.EquippedWeapon.Damage + Player.PotionEffects.DamageBoost);
                                        Player.PotionEffects.StatusEffect--;
                                    }
                                    
                                    Player.EquippedWeapon.UsesLeft--;
                                    Console.WriteLine($"{monster.DamageTakenLine} - {monster.Name} took {Player.EquippedWeapon.Damage} damage.");
                                    Player.RemoveWeaponFromPlayer(Player.EquippedWeapon);
                                }
                                else if (monster.Resistance = true)
                                {
                                    if (!Player.EquippedWeapon.IsRanged)
                                    {
                                        Console.WriteLine($"{monster.Name} is immune to melee and took 0 damage.");
                                    }
                                    else if (Player.EquippedWeapon.IsRanged = true)
                                    {
                                        monster.TakeDamage(Player.EquippedWeapon.Damage);
                                        Player.EquippedWeapon.UsesLeft--;
                                        Console.WriteLine($"{monster.DamageTakenLine} - {monster.Name} took {Player.EquippedWeapon.Damage} damage.");
                                        Player.RemoveWeaponFromPlayer(Player.EquippedWeapon);
                                    }
                                }
                            }
                            else
                            {
                                monster.TakeDamage(Player.BaseDamage);
                                Console.WriteLine($"{monster.DamageTakenLine} - {monster.Name} took {Player.BaseDamage} damage.");
                            }

                            usedTurn = true;

                            break;

                        case "equip":
                            string itemName = string.Join(" ", arguments);
                            Item? item = Player.FindItemByName(itemName);

                            if (item != null && item is Weapon)
                            {
                                Player.EquippedWeapon = (Weapon)item;
                                Console.WriteLine($"You equipped {item.Name}");
                            }

                            break;

                        case "use":
                            string PotionName = string.Join(" ", arguments);
                            Item? potion = Player.FindItemByName(PotionName);

                            if (potion != null && potion is Potion)
                            {
                                Potion potionCasted = (Potion)potion;

                                if (potionCasted.Type == "Healing")
                                {
                                    Player.Health = Player.Health + potionCasted.HealingBoost;

                                    Console.WriteLine($"You used {potionCasted.Name} and healed {potionCasted.HealingBoost} - Your HP is now {Player.Health}");
                                    Player.RemovePotionFromInventory(potionCasted);
                                }
                                if (potionCasted.Type == "Damage")
                                {
                                    Player.PotionEffects.StatusEffect = Player.PotionEffects.StatusEffect + potionCasted.StatusEffect;
                                    Player.InventoryToEffectsList(potionCasted);

                                    Console.WriteLine($"You used {potionCasted.Name} and boosted your ATK by {potionCasted.DamageBoost}x for 5 turns!");
                                    //Possibly make an object that holds effets for the player
                                }
                            }

                            break;

                        case "inventory":
                            Console.Clear();
                            Console.WriteLine("Inventory: ");
                            for (int i = 0; i < Player.Inventory.Count; i++)
                            {
                                Console.Write("{0}. {1} - {2}\n", i + 1, Player.Inventory[i].Name, Player.Inventory[i].Description);
                            }
                            Console.WriteLine();
                            GoToRoom(currentRoom);

                            break;
                    }
                }

                if (monster.Health > 0)
                {
                    Console.WriteLine("\n");
                    Player.TakeDamage(monster.Damage);
                    Console.WriteLine($"{monster.AttackLine} - {Player.Name} took {monster.Damage}");
                }
                else
                {
                    return true;
                }
            }

            return monster.Health <= 0;
        }
    }
}
