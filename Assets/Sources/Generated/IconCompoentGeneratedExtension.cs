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

        public IconCompoent iconCompoent { get { return (IconCompoent)GetComponent(CoreComponentIds.IconCompoent); } }
        public bool hasIconCompoent { get { return HasComponent(CoreComponentIds.IconCompoent); } }

        public Entity AddIconCompoent(UnityEngine.Sprite newSprite) {
            var component = CreateComponent<IconCompoent>(CoreComponentIds.IconCompoent);
            component.sprite = newSprite;
            return AddComponent(CoreComponentIds.IconCompoent, component);
        }

        public Entity ReplaceIconCompoent(UnityEngine.Sprite newSprite) {
            var component = CreateComponent<IconCompoent>(CoreComponentIds.IconCompoent);
            component.sprite = newSprite;
            ReplaceComponent(CoreComponentIds.IconCompoent, component);
            return this;
        }

        public Entity RemoveIconCompoent() {
            return RemoveComponent(CoreComponentIds.IconCompoent);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherIconCompoent;

        public static IMatcher IconCompoent {
            get {
                if(_matcherIconCompoent == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.IconCompoent);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherIconCompoent = matcher;
                }

                return _matcherIconCompoent;
            }
        }
    }
