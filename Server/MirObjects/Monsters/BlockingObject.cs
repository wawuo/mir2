using Server.MirDatabase;
using S = ServerPackets;
//这个文件应该是怪物AI的动作及一些特性
namespace Server.MirObjects.Monsters
{
    public class BlockingObject : MonsterObject //定义一个BlockingObject类，继承自MonsterObject类
    {
        public MonsterObject Parent; //定义一个公共属性Parent，类型为MonsterObject，表示这个阻挡物体的父物体
        public bool Visible; //定义一个公共属性Visible，类型为bool，表示这个阻挡物体是否可见

        protected internal BlockingObject(MonsterObject parent, MonsterInfo info) : base(info) //定义一个受保护的内部构造函数，接受两个参数，parent表示父物体，info表示信息，调用基类的构造函数
        {
            Parent = parent; //给Parent属性赋值为parent参数
            Visible = true; //给Visible属性赋值为true
        }

        public override bool Blocking //重写基类的Blocking属性，表示这个物体是否阻挡其他物体
        {
            get
            {
                return Parent.Blocking; //返回父物体的Blocking属性
            }
        }

        public override bool Walk(MirDirection dir) { return false; } //重写基类的Walk方法，表示这个物体是否能够沿着指定方向移动一格，直接返回false

        public override bool IsAttackTarget(MonsterObject attacker) //重写基类的IsAttackTarget方法，表示这个物体是否是指定怪物的攻击目标
        {
            return Parent.IsAttackTarget(attacker); //返回父物体的同名方法的结果
        }
        public override bool IsAttackTarget(HumanObject attacker) //重写基类的IsAttackTarget方法，表示这个物体是否是指定人类的攻击目标
        {
            return Parent.IsAttackTarget(attacker); //返回父物体的同名方法的结果
        }

        protected override void ProcessRoam() { } //重写基类的ProcessRoam方法，表示这个物体是否进行漫游逻辑，什么都不做

        protected override void ProcessSearch() { } //重写基类的ProcessSearch方法，表示这个物体是否进行搜索逻辑，什么都不做

        public override int Attacked(HumanObject attacker, int damage, DefenceType type = DefenceType.ACAgility, bool damageWeapon = true) //重写基类的Attacked方法，表示这个物体被指定人类攻击时的逻辑
        {
            return Parent.Attacked(attacker, damage, type, damageWeapon); //返回父物体的同名方法的结果
        }

        public override void Spawned() //重写基类的Spawned方法，表示这个物体被生成时的逻辑
        {
            base.Spawned(); //调用基类的同名方法
        }

        public override Packet GetInfo() //重写基类的GetInfo方法，表示获取这个物体的信息包
        {
            if (!Visible) return null; //如果不可见，就返回null

            return base.GetInfo(); //否则返回基类的同名方法的结果
        }

        public void Hide() //定义一个公共方法Hide，表示隐藏这个物体
        {
            Visible = false; //给Visible属性赋值为false

            if (CurrentMap == null) return; //如果当前地图为空，就返回

            CurrentMap.Broadcast(new S.ObjectRemove { ObjectID = ObjectID }, CurrentLocation); //在当前地图上广播一个S.ObjectRemove消息，告诉周围的玩家移除这个物体
        }

        public void Show() //定义一个公共方法Show，表示显示这个物体
        {
            Visible = true; //给Visible属性赋值为true

            if (CurrentMap == null) return; //如果当前地图为空，就返回

            Broadcast(GetInfo()); //广播自己的信息包给周围的玩家
        }
    }
}




//using Server.MirDatabase;
//using S = ServerPackets;

//namespace Server.MirObjects.Monsters
//{
//    public class BlockingObject : MonsterObject
//    {
//        public MonsterObject Parent;
//        public bool Visible;

//        protected internal BlockingObject(MonsterObject parent, MonsterInfo info) : base(info)
//        {
//            Parent = parent;
//            Visible = true;
//        }

//        public override bool Blocking
//        {
//            get
//            {
//                return Parent.Blocking;
//            }
//        }

//        public override bool Walk(MirDirection dir) { return false; }

//        public override bool IsAttackTarget(MonsterObject attacker)
//        {
//            return Parent.IsAttackTarget(attacker);
//        }
//        public override bool IsAttackTarget(HumanObject attacker)
//        {
//            return Parent.IsAttackTarget(attacker);
//        }

//        protected override void ProcessRoam() { }

//        protected override void ProcessSearch() { }

//        public override int Attacked(HumanObject attacker, int damage, DefenceType type = DefenceType.ACAgility, bool damageWeapon = true)
//        {
//            return Parent.Attacked(attacker, damage, type, damageWeapon);
//        }

//        public override void Spawned()
//        {
//            base.Spawned();
//        }

//        public override Packet GetInfo()
//        {
//            if (!Visible) return null;

//            return base.GetInfo();
//        }

//        public void Hide()
//        {
//            Visible = false;

//            if (CurrentMap == null) return;

//            CurrentMap.Broadcast(new S.ObjectRemove { ObjectID = ObjectID }, CurrentLocation);
//        }

//        public void Show()
//        {
//            Visible = true;

//            if (CurrentMap == null) return;

//            Broadcast(GetInfo());
//        }
//    }
//}
