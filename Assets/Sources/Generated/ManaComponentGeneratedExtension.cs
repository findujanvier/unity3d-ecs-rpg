//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        public ManaComponent mana { get { return (ManaComponent)GetComponent(ComponentIds.Mana); } }
        public bool hasMana { get { return HasComponent(ComponentIds.Mana); } }

        public Entity AddMana(float newAmount) {
            var component = CreateComponent<ManaComponent>(ComponentIds.Mana);
            component.amount = newAmount;
            return AddComponent(ComponentIds.Mana, component);
        }

        public Entity ReplaceMana(float newAmount) {
            var component = CreateComponent<ManaComponent>(ComponentIds.Mana);
            component.amount = newAmount;
            ReplaceComponent(ComponentIds.Mana, component);
            return this;
        }

        public Entity RemoveMana() {
            return RemoveComponent(ComponentIds.Mana);
        }
    }

    public partial class Pool {

        public Entity manaEntity { get { return GetGroup(Matcher.Mana).GetSingleEntity(); } }
        public ManaComponent mana { get { return manaEntity.mana; } }
        public bool hasMana { get { return manaEntity != null; } }

        public Entity SetMana(float newAmount) {
            if(hasMana) {
                throw new EntitasException("Could not set mana!\n" + this + " already has an entity with ManaComponent!",
                    "You should check if the pool already has a manaEntity before setting it or use pool.ReplaceMana().");
            }
            var entity = CreateEntity();
            entity.AddMana(newAmount);
            return entity;
        }

        public Entity ReplaceMana(float newAmount) {
            var entity = manaEntity;
            if(entity == null) {
                entity = SetMana(newAmount);
            } else {
                entity.ReplaceMana(newAmount);
            }

            return entity;
        }

        public void RemoveMana() {
            DestroyEntity(manaEntity);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherMana;

        public static IMatcher Mana {
            get {
                if(_matcherMana == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Mana);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherMana = matcher;
                }

                return _matcherMana;
            }
        }
    }
}
