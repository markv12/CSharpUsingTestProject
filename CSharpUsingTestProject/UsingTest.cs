using RegularNamespace;
using OtherRegularNamespace;
using AliasedClass = OtherRegularNamespace.ClassWithSameName;

//using System.Collections.Generic;
//using AliasedList = List<int>; //Doesn't work
//using AliasedList = System.Collections.Generic.List<T>; //Doesn't work
using AliasedList = System.Collections.Generic.List<int>;

using static NamespaceWithStatic.ClassForStatic;
using static NamespaceWithStatic.OtherClassForStatic;
using static NamespaceWithStatic.EnumForStatic;

//using NamespaceWithStatic;
//using static ClassForStatic; //Doesn't Work

//using static OtherClassInMainNamespace; //Doesn't work
using static MainNamespace.OtherClassInMainNamespace;


namespace MainNamespace {
    public class UsingTest {
        public static void Test() {
            ClassInRegularNamespace newObject = new ClassInRegularNamespace();

            //ClassWithSameName sameNameObject = new ClassWithSameName(); //Doesn't work
            AliasedClass aliasedObject = new AliasedClass();
            AliasedList aliasedList = new AliasedList();

            StaticMethod();
            StaticMethod(2);
            EnumMethod(EnumValue2);
            StaticMethodInSameNamespace();
            NestedClassForStatic newNestedObject = new NestedClassForStatic();

            ClassForGlobal newGlobalObject = new ClassForGlobal();
            StaticGlobalMethod();
        }
    }
}

