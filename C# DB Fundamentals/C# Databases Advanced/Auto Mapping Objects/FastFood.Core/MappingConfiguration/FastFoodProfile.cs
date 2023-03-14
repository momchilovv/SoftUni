namespace FastFood.Core.MappingConfiguration
{
    using AutoMapper;
    using FastFood.Core.ViewModels.Categories;
    using FastFood.Core.ViewModels.Employees;
    using FastFood.Core.ViewModels.Items;
    using FastFood.Core.ViewModels.Orders;
    using FastFood.Models;
    using FastFood.Models.Enums;
    using ViewModels.Positions;

    public class FastFoodProfile : Profile
    {
        public FastFoodProfile()
        {
            //Positions
            CreateMap<CreatePositionInputModel, Position>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.PositionName));

            CreateMap<Position, PositionsAllViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Name));

            //Items
            CreateMap<Category, CreateItemViewModel>()
                .ForMember(x => x.CategoryId, y => y.MapFrom(s => s.Id));

            CreateMap<CreateItemInputModel, Item>();

            CreateMap<Item, ItemsAllViewModels>()
                .ForMember(x => x.Category, y => y.MapFrom(s => s.Category.Name));

            //Categories
            CreateMap<Category, CategoryAllViewModel>();

            //Employees
            CreateMap<Position, RegisterEmployeeViewModel>()
                .ForMember(x => x.PositionId, y => y.MapFrom(s => s.Id));

            CreateMap<RegisterEmployeeInputModel, Employee>();

            CreateMap<Employee, EmployeesAllViewModel>()
                .ForMember(x => x.Position, y => y.MapFrom(s => s.Position.Name));

            //Orders
            CreateMap<Order, OrderAllViewModel>()
                .ForMember(x => x.Employee, y => y.MapFrom(s => s.Employee.Name))
                .ForMember(x => x.DateTime, y => y.MapFrom(s => s.DateTime.ToString("dd/MM/yyyy HH:mm:ss")))
                .ForMember(x => x.OrderId, y => y.MapFrom(s => s.Id));

            CreateMap<CreateOrderInputModel,  OrderItem>()
                .ForMember(x => x.ItemId, y => y.MapFrom(s => s.ItemId))
                .ForMember(x => x.Quantity, y => y.MapFrom(s => s.Quantity));

            CreateMap<CreateOrderInputModel, Order>()
                .ForMember(x => x.DateTime, y => y.MapFrom(s => DateTime.Now))
                .ForMember(x => x.Type, y => y.MapFrom(s => OrderType.ToGo));
        }
    }
}
