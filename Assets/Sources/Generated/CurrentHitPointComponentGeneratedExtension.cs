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

        public CurrentHitPointComponent currentHitPoint { get { return (CurrentHitPointComponent)GetComponent(CoreComponentIds.CurrentHitPoint); } }
        public bool hasCurrentHitPoint { get { return HasComponent(CoreComponentIds.CurrentHitPoint); } }

        public Entity AddCurrentHitPoint(int newAmount) {
            var component = CreateComponent<CurrentHitPointComponent>(CoreComponentIds.CurrentHitPoint);
            component.amount = newAmount;
            return AddComponent(CoreComponentIds.CurrentHitPoint, component);
        }

        public Entity ReplaceCurrentHitPoint(int newAmount) {
            var component = CreateComponent<CurrentHitPointComponent>(CoreComponentIds.CurrentHitPoint);
            component.amount = newAmount;
            ReplaceComponent(CoreComponentIds.CurrentHitPoint, component);
            return this;
        }

        public Entity RemoveCurrentHitPoint() {
            return RemoveComponent(CoreComponentIds.CurrentHitPoint);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherCurrentHitPoint;

        public static IMatcher CurrentHitPoint {
            get {
                if(_matcherCurrentHitPoint == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.CurrentHitPoint);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherCurrentHitPoint = matcher;
                }

                return _matcherCurrentHitPoint;
            }
        }
    }
