namespace RegularNamespace {
    public class RegularClass { }

    public class NameConflictClass { }
}

namespace OtherNamespace {
    public class NameConflictClass { }
}

namespace NamespaceForStatic {
    public class ClassForStatic {
        public static void StaticMethod() { }
        public static string stringFromStatic = "string form static";
        public class NestedClass { }
    }
    public class OtherClassForStatic {
        public static void StaticMethod(string parameter) { }

        //public static string stringFromStatic = "other string form static"; //If uncommented, ClassForStatic and OtherClassForStatic can't be used together
        //public class NestedClass {} //If uncommented, ClassForStatic and OtherClassForStatic can't be used together
    }

    public enum EnumForStatic {
        EnumValue1,
        EnumValue2,
        EnumValue3
    }
}

namespace MainNamespace {
    public class OtherClassInMainNamespace {
        public static void StaticMethodInSameNamespace() { }
    }
}

namespace NamespaceForGlobal {
    public class ClassForGlobal { }
    public class ExtraClassForGlobal { }
}

namespace NamespaceForStaticGlobal {
    public class ClassForStaticGlobal {
        public static void StaticGlobalMethod() { }
    }
}