using System.Globalization;
using System.Threading.Tasks;
using ArknightsResources.Operators.Models;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一套用以获取与干员相关信息的方法
    /// </summary>
    public interface IOperatorInfoGetter
    {
#if NET7_0_OR_GREATER
        /// <summary>
        /// 通过干员名称获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Operator GetOperator(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员名称异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Task<Operator> GetOperatorAsync(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员内部代号获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员内部代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Operator GetOperatorWithCodename(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员内部代号异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员内部代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Task<Operator> GetOperatorWithCodenameAsync(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取当前可用的全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        public static abstract OperatorsList GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取当前可用的全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        public static abstract Task<OperatorsList> GetAllOperatorsAsync(CultureInfo cultureInfo);
#else
        /// <summary>
        /// 通过干员名称获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Operator GetOperator(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员名称异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Task<Operator> GetOperatorAsync(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员内部代号获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员内部代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Operator GetOperatorWithCodename(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员内部代号异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员内部代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Task<Operator> GetOperatorWithCodenameAsync(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取当前可用的全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        OperatorsList GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取当前可用的全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        Task<OperatorsList> GetAllOperatorsAsync(CultureInfo cultureInfo);
#endif
    }
}