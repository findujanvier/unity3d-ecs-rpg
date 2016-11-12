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

        public ExpComponent exp { get { return (ExpComponent)GetComponent(CoreComponentIds.Exp); } }
        public bool hasExp { get { return HasComponent(CoreComponentIds.Exp); } }

        public Entity AddExp(int newValue) {
            var component = CreateComponent<ExpComponent>(CoreComponentIds.Exp);
            component.value = newValue;
            return AddComponent(CoreComponentIds.Exp, component);
        }

        public Entity ReplaceExp(int newValue) {
            var component = CreateComponent<ExpComponent>(CoreComponentIds.Exp);
            component.value = newValue;
            ReplaceComponent(CoreComponentIds.Exp, component);
            return this;
        }

        public Entity RemoveExp() {
            return RemoveComponent(CoreComponentIds.Exp);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherExp;

        public static IMatcher Exp {
            get {
                if(_matcherExp == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Exp);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherExp = matcher;
                }

                return _matcherExp;
            }
        }
    }