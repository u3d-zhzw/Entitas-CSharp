//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

[Entitas.Serialization.Blueprints.HideInBlueprintInspectorAttribute]
public class SomeClassHideInBlueprintInspectorComponent : IComponent {

    public SomeClassHideInBlueprintInspector value;
}

namespace Entitas {

    public partial class Entity {

        public SomeClassHideInBlueprintInspectorComponent someClassHideInBlueprintInspector { get { return (SomeClassHideInBlueprintInspectorComponent)GetComponent(ComponentIds.SomeClassHideInBlueprintInspector); } }
        public bool hasSomeClassHideInBlueprintInspector { get { return HasComponent(ComponentIds.SomeClassHideInBlueprintInspector); } }

        public void AddSomeClassHideInBlueprintInspector(SomeClassHideInBlueprintInspector newValue) {
            var component = CreateComponent<SomeClassHideInBlueprintInspectorComponent>(ComponentIds.SomeClassHideInBlueprintInspector);
            component.value = newValue;
            AddComponent(ComponentIds.SomeClassHideInBlueprintInspector, component);
        }

        public void ReplaceSomeClassHideInBlueprintInspector(SomeClassHideInBlueprintInspector newValue) {
            var component = CreateComponent<SomeClassHideInBlueprintInspectorComponent>(ComponentIds.SomeClassHideInBlueprintInspector);
            component.value = newValue;
            ReplaceComponent(ComponentIds.SomeClassHideInBlueprintInspector, component);
        }

        public void RemoveSomeClassHideInBlueprintInspector() {
            RemoveComponent(ComponentIds.SomeClassHideInBlueprintInspector);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherSomeClassHideInBlueprintInspector;

        public static IMatcher SomeClassHideInBlueprintInspector {
            get {
                if(_matcherSomeClassHideInBlueprintInspector == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.SomeClassHideInBlueprintInspector);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherSomeClassHideInBlueprintInspector = matcher;
                }

                return _matcherSomeClassHideInBlueprintInspector;
            }
        }
    }
}