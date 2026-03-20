using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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
        [Description("red")]
        red = 1,
        [Description("blue")]
        blue = 2,
        [Description("green")]
        green = 3,
        [Description("yellow")]
        yellow = 4,
        [Description("black")]
        black = 5,
        [Description("white")]
        white = 6
    }
    public enum ProductSizeEnum
    {
        [Description("mini")]
        mini = 1,
        [Description("small")]
        small = 2,
        [Description("medium")]
        medium = 3,
        [Description("large")]
        large = 4,
        [Description("extraLarge")]
        extraLarge = 5
    }
    public enum WarehouseTypeEnum
    {
        [Description("DistributionCenter")]
        DistributionCenter = 1,
        [Description("RegionalWarehouse")]
        RegionalWarehouse = 2,
        [Description("LocalWarehouse")]
        LocalWarehouse = 3,
        [Description("CrossDockingFacility")]
        CrossDockingFacility = 4,
        [Description("FulfillmentCenter")]
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
    public class EnumTranslateClass()
    {
        // 获取枚举的 [Description] 特性文本
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }
    }
}
