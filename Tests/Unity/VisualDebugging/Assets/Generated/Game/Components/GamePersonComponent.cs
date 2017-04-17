//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PersonComponent person { get { return (PersonComponent)GetComponent(GameComponentsLookup.Person); } }
    public bool hasPerson { get { return HasComponent(GameComponentsLookup.Person); } }

    public void AddPerson(string newName, string newGender) {
        var index = GameComponentsLookup.Person;
        var component = CreateComponent<PersonComponent>(index);
        component.name = newName;
        component.gender = newGender;
        AddComponent(index, component);
    }

    public void ReplacePerson(string newName, string newGender) {
        var index = GameComponentsLookup.Person;
        var component = CreateComponent<PersonComponent>(index);
        component.name = newName;
        component.gender = newGender;
        ReplaceComponent(index, component);
    }

    public void RemovePerson() {
        RemoveComponent(GameComponentsLookup.Person);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPerson;

    public static Entitas.IMatcher<GameEntity> Person {
        get {
            if(_matcherPerson == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Person);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPerson = matcher;
            }

            return _matcherPerson;
        }
    }
}
