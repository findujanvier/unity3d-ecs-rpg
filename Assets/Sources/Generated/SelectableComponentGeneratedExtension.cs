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

        static readonly SelectableComponent selectableComponent = new SelectableComponent();

        public bool isSelectable {
            get { return HasComponent(ComponentIds.Selectable); }
            set {
                if(value != isSelectable) {
                    if(value) {
                        AddComponent(ComponentIds.Selectable, selectableComponent);
                    } else {
                        RemoveComponent(ComponentIds.Selectable);
                    }
                }
            }
        }

        public Entity IsSelectable(bool value) {
            isSelectable = value;
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherSelectable;

        public static IMatcher Selectable {
            get {
                if(_matcherSelectable == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Selectable);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherSelectable = matcher;
                }

                return _matcherSelectable;
            }
        }
    }
}
