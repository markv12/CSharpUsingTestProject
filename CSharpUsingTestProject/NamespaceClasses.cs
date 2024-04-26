namespace RegularNamespace {
    public class ClassInRegularNamespace { }

    public class ClassWithSameName { }
}

namespace OtherRegularNamespace {
    public class ClassWithSameName { }
}

namespace NamespaceWithStatic {
    public class ClassForStatic {
        public static void StaticMethod() { }
        public static void EnumMethod(EnumForStatic enumParams) { }

        public class NestedClassForStatic { }
    }
    public class OtherClassForStatic {
        public static void StaticMethod(int parameter) { }

        //public class NestedClassForStatic {} //If uncommented, ClassForStatic and OtherClassForStatic can't be used together
    }

    public enum EnumForStatic {
        EnumValue1,
        EnumValue2,
        EnumValue3
    }
}

