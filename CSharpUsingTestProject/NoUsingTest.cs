namespace MainNamespace {
    public class NoUsingTest {
        public static void Test() {
            RegularNamespace.RegularClass newObject = new RegularNamespace.RegularClass();

            OtherNamespace.NameConflictClass aliasedObject = new OtherNamespace.NameConflictClass();
            System.Collections.Generic.List<int> aliasedList = new System.Collections.Generic.List<int>();

            NamespaceForStatic.ClassForStatic.StaticMethod();
            NamespaceForStatic.OtherClassForStatic.StaticMethod(NamespaceForStatic.ClassForStatic.stringFromStatic);
            EnumMethod(NamespaceForStatic.EnumForStatic.EnumValue2);
            OtherClassInMainNamespace.StaticMethodInSameNamespace();
            NamespaceForStatic.ClassForStatic.NestedClass newNestedObject = new NamespaceForStatic.ClassForStatic.NestedClass();

            ClassForGlobal newGlobalObject = new ClassForGlobal();
            StaticGlobalMethod();
        }

        public static void EnumMethod(NamespaceForStatic.EnumForStatic enumParam) { }
    }
}

