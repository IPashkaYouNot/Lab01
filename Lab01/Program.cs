using Data;

namespace Lab01
{
    internal class Program
    {
        static void Main()
        {
            var data = DataSeeding.GetData();
            var queries = new Queries(data);
            RealiseOptions(queries);
        }

        static void PrintAllOptions()
        {
            Console.WriteLine("Choose from 1 to 15 or 0 to quit.");
            Console.WriteLine("1. Print start point and amount of buses starting on this point.");
            Console.WriteLine("2. Print number of buses that run on routes with more than three buses.");
            Console.WriteLine("3. Print companies with the biggest amount of routes.");
            Console.WriteLine("4. Print first and last three buses.");
            Console.WriteLine("5. Print routes with it\'s companies.");
            Console.WriteLine("6. Print common routes between first and second buses.");
            Console.WriteLine("7. Print list of the same amount of routes for buses.");
            Console.WriteLine("8. Print car city codes with their amount.");
            Console.WriteLine("9. Print all start and end points.");
            Console.WriteLine("10. Print routes with the same amount of buses.");
            Console.WriteLine("11. Print avarage amount of buses among routes.");
            Console.WriteLine("12. Print all buses except buses on first and last route.");
            Console.WriteLine("13. Print amount of symbols in routes.");
            Console.WriteLine("14. Print all routes of companies.");
            Console.WriteLine("15. Print all ordered bus numbers.");
            Console.WriteLine("0. Quit.");
        }

        static void RealiseOptions(Queries queries)
        {
            var finished = false;
            while (!finished)
            {
                PrintAllOptions();
                string? opt = Console.ReadLine();
                if (opt is null || !int.TryParse(opt, out int result) || result < 0 || result > 15)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong option. Try again.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }
                switch (result)
                {
                    case 0:
                        Console.WriteLine("Program finished.");
                        finished = true;
                        break;
                    case 1:
                        {
                            var res = queries.GroupByStartPointAndCount();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 2:
                        {
                            var res = queries.SelectBusesOnRoutesWithMoreThanGivenAmountOfBuses(3);
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 3:
                        {
                            var res = queries.GetCompaniesWithTheBiggestAmountOfRoutes();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 4:
                        {
                            var res = queries.GetFirstAndLastThreeBuses();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 5:
                        {
                            var res = queries.CompanyRouteJoin();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item.Name1 + " " + item.Name2);
                            }
                            break;
                        }
                    case 6:
                        {
                            var res = queries.CommonRoutesBetweenFirstAndSecondBus();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 7:
                        {
                            var res = queries.GroupingBusesByAmountOfRoutesOnEach();
                            foreach (var item in res)
                            {
                                Console.WriteLine("Amount: " + item.Name1 + ", buses: " + item.Name2);
                            }
                            break;
                        }
                    case 8:
                        {
                            var res = queries.GroupingByCarCodes();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item.Name1 + " - " + item.Name2);
                            }
                            break;
                        }
                    case 9:
                        {
                            var res = queries.GetAllEndAndStartPoints();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item.Name);
                            }
                            break;
                        }
                    case 10:
                        {
                            var res = queries.SortRoutesByAmountOfBuses();
                            foreach (var item in res)
                            {
                                Console.WriteLine("Routes: " + item.Name2 + " with " + item.Name1);
                            }
                            break;
                        }
                    case 11:
                        {
                            var res = queries.AvarageAmountOfBusesAmongRoutes();
                            Console.WriteLine("Avarage amount: " + res);
                            break;
                        }
                    case 12:
                        {
                            var res = queries.AllBusesExceptFirstAndLastRoute();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 13:
                        {
                            var res = queries.GroupRoutesByAmountOfSymbolsInName();
                            foreach (var item in res)
                            {
                                Console.WriteLine("Number of symbols: " + item.Name1 + ", routes: " + item.Name2);
                            }
                            break;
                        }
                    case 14:
                        {
                            var res = queries.GetAllRoutesOfCompanies();
                            foreach (var item in res)
                            {
                                Console.WriteLine("Company \"" + item.Name1 + "\" has routes: " + item.Name2);
                            }
                            break;
                        }
                    case 15:
                        {
                            var res = queries.OrderAllBusNumbers();
                            foreach (var item in res)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                }

                Console.Write("Press any button to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}