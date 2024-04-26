using RegularNamespace;
//using RegularNamespace.RegularClass; //Doesn't work
using NameConflictClass = OtherNamespace.NameConflictClass;

//using System.Collections.Generic;
//using AliasedList = List<int>; //Doesn't work

//using AliasedList = System.Collections.Generic.List<T>; //Doesn't work
using AliasedList = System.Collections.Generic.List<int>;

using static NamespaceForStatic.ClassForStatic;
using static NamespaceForStatic.OtherClassForStatic;
using static NamespaceForStatic.EnumForStatic;

//using NamespaceWithStatic;
//using static ClassForStatic; //Doesn't Work

//using static OtherClassInMainNamespace; //Doesn't work
using static MainNamespace.OtherClassInMainNamespace;


namespace MainNamespace {
    public class UsingTest {
        public static void Test() {
            RegularClass newObject = new RegularClass();

            NameConflictClass aliasedObject = new NameConflictClass();
            AliasedList aliasedList = new AliasedList();

            StaticMethod();
            StaticMethod(stringFromStatic);
            NestedClass newNestedObject = new NestedClass();
            EnumMethod(EnumValue2);
            StaticMethodInSameNamespace();

            ClassForGlobal newGlobalObject = new ClassForGlobal();
            GlobalAliasClass globalAliasedObject = new GlobalAliasClass();
            StaticGlobalMethod();
        }

        public static void EnumMethod(NamespaceForStatic.EnumForStatic enumParam) { }
    }
}

