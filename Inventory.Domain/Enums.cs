using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Enums

{
    public enum UserRoleEnum
    {
        Admin = 1, // 管理员
        Manager = 2, // 经理
        Staff = 3, // 员工
        Viewer = 4 // 观察者
    }
    public enum ProductCategoryEnum
    {
        Electronics = 1, // 电子产品
        Clothing = 2, // 服装
        Food = 3, // 食品
        Furniture = 4, // 家具
        Books = 5, // 图书
        Toys = 6 // 玩具
    }
    public enum ProductColorEnum
    {
        red = 1,
        blue = 2,
        green = 3,
        yellow = 4,
        black = 5,
        white = 6
    }
    public enum ProductSizeEnum
    {
        mini = 1,
        small = 2,
        medium = 3,
        large = 4,
        extraLarge = 5
    }
    public enum WarehouseTypeEnum
    {
        DistributionCenter = 1,
        RegionalWarehouse = 2,
        LocalWarehouse = 3,
        CrossDockingFacility = 4,
        FulfillmentCenter = 5
    }
    public enum ChangeTypeEnum
    {
        Inbound = 1, // 入库
        Outbound = 2 // 出库
    }
    public enum ProductOperationStateEnum
    {
        Available = 1, // 可用
        Reserved = 2, // 已预留
        Damaged = 3, // 已损坏
        InTransit = 4, // 在途
        Returned = 5 // 已退货
    }
    public enum ProductAllocationRulesEnum
    {
        None = 0,
    }
}
