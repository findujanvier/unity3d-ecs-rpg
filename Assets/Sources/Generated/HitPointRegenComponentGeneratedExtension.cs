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

        public HitPointRegenComponent hitPointRegen { get { return (HitPointRegenComponent)GetComponent(CoreComponentIds.HitPointRegen); } }
        public bool hasHitPointRegen { get { return HasComponent(CoreComponentIds.HitPointRegen); } }

        public Entity AddHitPointRegen(float newRate, float newInterval, float newDuration) {
            var component = CreateComponent<HitPointRegenComponent>(CoreComponentIds.HitPointRegen);
            component.rate = newRate;
            component.interval = newInterval;
            component.duration = newDuration;
            return AddComponent(CoreComponentIds.HitPointRegen, component);
        }

        public Entity ReplaceHitPointRegen(float newRate, float newInterval, float newDuration) {
            var component = CreateComponent<HitPointRegenComponent>(CoreComponentIds.HitPointRegen);
            component.rate = newRate;
            component.interval = newInterval;
            component.duration = newDuration;
            ReplaceComponent(CoreComponentIds.HitPointRegen, component);
            return this;
        }

        public Entity RemoveHitPointRegen() {
            return RemoveComponent(CoreComponentIds.HitPointRegen);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherHitPointRegen;

        public static IMatcher HitPointRegen {
            get {
                if(_matcherHitPointRegen == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.HitPointRegen);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherHitPointRegen = matcher;
                }

                return _matcherHitPointRegen;
            }
        }
    }
