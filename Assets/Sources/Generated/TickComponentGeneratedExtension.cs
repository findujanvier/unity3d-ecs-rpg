//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public TickComponent tick { get { return (TickComponent)GetComponent(CoreComponentIds.Tick); } }
        public bool hasTick { get { return HasComponent(CoreComponentIds.Tick); } }

        public Entity AddTick(long newCurrentTick) {
            var component = CreateComponent<TickComponent>(CoreComponentIds.Tick);
            component.currentTick = newCurrentTick;
            return AddComponent(CoreComponentIds.Tick, component);
        }

        public Entity ReplaceTick(long newCurrentTick) {
            var component = CreateComponent<TickComponent>(CoreComponentIds.Tick);
            component.currentTick = newCurrentTick;
            ReplaceComponent(CoreComponentIds.Tick, component);
            return this;
        }

        public Entity RemoveTick() {
            return RemoveComponent(CoreComponentIds.Tick);
        }
    }

    public partial class Pool {

        public Entity tickEntity { get { return GetGroup(CoreMatcher.Tick).GetSingleEntity(); } }
        public TickComponent tick { get { return tickEntity.tick; } }
        public bool hasTick { get { return tickEntity != null; } }

        public Entity SetTick(long newCurrentTick) {
            if(hasTick) {
                throw new EntitasException("Could not set tick!\n" + this + " already has an entity with TickComponent!",
                    "You should check if the pool already has a tickEntity before setting it or use pool.ReplaceTick().");
            }
            var entity = CreateEntity();
            entity.AddTick(newCurrentTick);
            return entity;
        }

        public Entity ReplaceTick(long newCurrentTick) {
            var entity = tickEntity;
            if(entity == null) {
                entity = SetTick(newCurrentTick);
            } else {
                entity.ReplaceTick(newCurrentTick);
            }

            return entity;
        }

        public void RemoveTick() {
            DestroyEntity(tickEntity);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherTick;

        public static IMatcher Tick {
            get {
                if(_matcherTick == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Tick);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherTick = matcher;
                }

                return _matcherTick;
            }
        }
    }
