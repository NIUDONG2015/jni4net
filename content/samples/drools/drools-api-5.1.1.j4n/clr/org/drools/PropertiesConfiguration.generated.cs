//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface PropertiesConfiguration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        void setProperty(global::java.lang.String par0, global::java.lang.String par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        global::java.lang.String getProperty(global::java.lang.String par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class PropertiesConfiguration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@__PropertiesConfiguration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.PropertiesConfiguration), typeof(global::org.drools.PropertiesConfiguration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.PropertiesConfiguration), typeof(global::org.drools.PropertiesConfiguration_))]
    internal sealed partial class @__PropertiesConfiguration : global::java.lang.Object, global::org.drools.PropertiesConfiguration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProperty0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty1;
        
        private @__PropertiesConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@__PropertiesConfiguration.staticClass = @__class;
            global::org.drools.@__PropertiesConfiguration._setProperty0 = @__env.GetMethodID(global::org.drools.@__PropertiesConfiguration.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::org.drools.@__PropertiesConfiguration._getProperty1 = @__env.GetMethodID(global::org.drools.@__PropertiesConfiguration.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
        }
        
        public void setProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.@__PropertiesConfiguration._setProperty0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        public global::java.lang.String getProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@__PropertiesConfiguration._getProperty1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__PropertiesConfiguration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setProperty", "setProperty0", "(Ljava/lang/String;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProperty", "getProperty1", "(Ljava/lang/String;)Ljava/lang/String;"));
            return methods;
        }
        
        private static void setProperty0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/String;Ljava/lang/String;)V
            // (Ljava/lang/String;Ljava/lang/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.PropertiesConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.PropertiesConfiguration>(@__env, @__obj);
            @__real.setProperty(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProperty1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (Ljava/lang/String;)Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.PropertiesConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.PropertiesConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getProperty(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@__PropertiesConfiguration(@__env);
            }
        }
    }
    #endregion
}
