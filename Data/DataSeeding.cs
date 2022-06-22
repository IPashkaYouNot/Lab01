using Model;

namespace Data
{
    static public class DataSeeding
    {
        public static Assets GetData()
        {
            // companies
            var comp1 = new Company { Id = Guid.NewGuid(), Name = "Zhytomyr buses" };
            var comp2 = new Company { Id = Guid.NewGuid(), Name = "Zhytomyr travel" };
            var comp3 = new Company { Id = Guid.NewGuid(), Name = "One way to Zhytomyr" };
            var comp4 = new Company { Id = Guid.NewGuid(), Name = "Public transport" };

            var companies = new List<Company> { comp1, comp2, comp3, comp4 };

            // points
            var point1 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Kyivska"
            };

            var point2 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Nebesnoi sotni"
            };

            var point3 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Mykhailivska"
            };

            var point4 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Ploscha Peremogy"
            };

            var point5 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Lesy Ukrainki"
            };

            var point6 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Schevchenka"
            };

            var point7 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Dombrovskogo"
            };

            var point8 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Gruschevskogo"
            };

            var point9 = new Point
            {
                Id = Guid.NewGuid(),
                Name = "Chehova"
            };

            // routes
            var route1 = new Route
            {
                RouteId = Guid.NewGuid(),
                Name = "3",
                Company = comp1,
                StartPoint = point1,
                EndPoint = point2,
                Duration = 1
            };
            comp1.Routes.Add(route1);

            var route2 = new Route
            {
                RouteId = Guid.NewGuid(),
                Name = "33",
                Company = comp2,
                StartPoint = point3,
                EndPoint = point4,
                Duration = 1.5
            };
            comp2.Routes.Add(route2);

            var route3 = new Route
            {
                RouteId = Guid.NewGuid(),
                Name = "223",
                Company = comp4,
                StartPoint = point5,
                EndPoint = point6,
                Duration = 0.7
            };
            comp4.Routes.Add(route3);

            var route4 = new Route
            {
                RouteId = Guid.NewGuid(),
                Name = "99",
                Company = comp3,
                StartPoint = point7,
                EndPoint = point8,
                Duration = 0.8
            };
            comp3.Routes.Add(route4);

            var route5 = new Route
            {
                RouteId = Guid.NewGuid(),
                Name = "41",
                Company = comp1,
                StartPoint = point7,
                EndPoint = point5,
                Duration = 0.3
            };
            comp1.Routes.Add(route5);

            var route6 = new Route
            {
                RouteId = Guid.NewGuid(),
                Name = "24",
                Company = comp1,
                StartPoint = point5,
                EndPoint = point9,
                Duration = 1.2
            };
            comp1.Routes.Add(route6);

            var routes = new List<Route> { route1, route2, route3, route4, route5, route6 };

            // buses
            var bus1 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AC 1234 AA",
                Routes = new List<Route> { route1, route5, route6 }
            };
            route1.Buses.Add(bus1);

            var bus2 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AA 1221 AA",
                Routes = new List<Route> { route1, route5, route6 }
            };
            route5.Buses.Add(bus2);

            var bus3 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AC 3782 AA",
                Routes = new List<Route> { route1, route5, route6 }
            };
            route5.Buses.Add(bus3);

            var bus4 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "BO 7591 AA",
                Routes = new List<Route> { route1, route5, route6 }
            };
            route6.Buses.Add(bus4);

            var bus5 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "BO 1940 AA",
                Routes = new List<Route> { route1, route5, route6 }
            };
            route6.Buses.Add(bus5);

            var bus6 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "BB 1001 AA",
                Routes = new List<Route> { route2 }
            };
            route2.Buses.Add(bus6);

            var bus7 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AM 2958 AA",
                Routes = new List<Route> { route2 }
            };
            route2.Buses.Add(bus7);

            var bus8 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AM 0593 AA",
                Routes = new List<Route> { route2 }
            };
            route2.Buses.Add(bus8);

            var bus9 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AA 4664 AA",
                Routes = new List<Route> { route3 }
            };
            route3.Buses.Add(bus9);

            var bus10 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AM 2059 AA",
                Routes = new List<Route> { route3 }
            };
            route3.Buses.Add(bus10);

            var bus11 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "BE 3987 AA",
                Routes = new List<Route> { route3 }
            };
            route3.Buses.Add(bus11);

            var bus12 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "BI 4660 AA",
                Routes = new List<Route> { route3 }
            };
            route3.Buses.Add(bus12);

            var bus13 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "BI 4774 AA",
                Routes = new List<Route> { route4 }
            };
            route4.Buses.Add(bus13);

            var bus14 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AM 4772 AA",
                Routes = new List<Route> { route4 }
            };
            route4.Buses.Add(bus14);

            var bus15 = new Bus
            {
                Id = Guid.NewGuid(),
                Number = "AM 4753 AA",
                Routes = new List<Route> { route4 }
            };
            route4.Buses.Add(bus15);

            var buses = new List<Bus> { bus1, bus2, bus3, bus4, bus5, bus6, bus7, bus8,
                bus9, bus10, bus11, bus12, bus13, bus14, bus15 };

            // bus routes
            var br1 = new BusRoute { Bus = bus1, Route = route1 };
            var br2 = new BusRoute { Bus = bus1, Route = route5 };
            var br3 = new BusRoute { Bus = bus1, Route = route6 };

            var br4 = new BusRoute { Bus = bus2, Route = route1 };
            var br5 = new BusRoute { Bus = bus2, Route = route5 };
            var br6 = new BusRoute { Bus = bus2, Route = route6 };

            var br7 = new BusRoute { Bus = bus3, Route = route1 };
            var br8 = new BusRoute { Bus = bus3, Route = route5 };
            var br9 = new BusRoute { Bus = bus3, Route = route6 };

            var br10 = new BusRoute { Bus = bus4, Route = route1 };
            var br11 = new BusRoute { Bus = bus4, Route = route5 };
            var br12 = new BusRoute { Bus = bus4, Route = route6 };

            var br13 = new BusRoute { Bus = bus5, Route = route1 };
            var br14 = new BusRoute { Bus = bus5, Route = route5 };
            var br15 = new BusRoute { Bus = bus5, Route = route6 };

            var br16 = new BusRoute { Bus = bus6, Route = route2 };
            var br17 = new BusRoute { Bus = bus7, Route = route2 };
            var br18 = new BusRoute { Bus = bus8, Route = route2 };

            var br19 = new BusRoute { Bus = bus9, Route = route3 };
            var br20 = new BusRoute { Bus = bus10, Route = route3 };
            var br21 = new BusRoute { Bus = bus11, Route = route3 };
            var br22 = new BusRoute { Bus = bus12, Route = route3 };

            var br23 = new BusRoute { Bus = bus13, Route = route4 };
            var br24 = new BusRoute { Bus = bus14, Route = route4 };
            var br25 = new BusRoute { Bus = bus15, Route = route4 };

            var busRoutes = new List<BusRoute> { br1, br2, br3, br4,
                br5, br6, br7, br8, br9, br10, br11, br12, br13, br14,
                br15, br16, br17, br18, br19, br20, br21, br22, br23, br24, br25 };


            return new Assets { Companies = companies, Buses = buses, BusRoutes = busRoutes, Routes = routes };
        }
    }
}
