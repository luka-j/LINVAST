#nullable disable
namespace LINVAST.Imperative.Builders.Lua
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     This code was generated by a tool.
    //     ANTLR Version: 4.7.1
    //
    //     Changes to this file may cause incorrect behavior and will be lost if
    //     the code is regenerated.
    // </auto-generated>
    //------------------------------------------------------------------------------

    // Generated from Lua.g4 by ANTLR 4.7.1

    // Unreachable code detected
#pragma warning disable 0162
    // The variable '...' is assigned but its value is never used
#pragma warning disable 0219
    // Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
    // Ambiguous reference in cref attribute
#pragma warning disable 419

    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;

    /// <summary>
    /// This interface defines a complete generic visitor for a parse tree produced
    /// by <see cref="LuaParser"/>.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]

    public interface ILuaVisitor<Result> : IParseTreeVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.chunk"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitChunk([NotNull] LuaParser.ChunkContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.block"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitBlock([NotNull] LuaParser.BlockContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.stat"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStat([NotNull] LuaParser.StatContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.retstat"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitRetstat([NotNull] LuaParser.RetstatContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.label"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitLabel([NotNull] LuaParser.LabelContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.funcname"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitFuncname([NotNull] LuaParser.FuncnameContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.varlist"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitVarlist([NotNull] LuaParser.VarlistContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.namelist"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitNamelist([NotNull] LuaParser.NamelistContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.explist"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitExplist([NotNull] LuaParser.ExplistContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.exp"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitExp([NotNull] LuaParser.ExpContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.prefixexp"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitPrefixexp([NotNull] LuaParser.PrefixexpContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.functioncall"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitFunctioncall([NotNull] LuaParser.FunctioncallContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.varOrExp"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitVarOrExp([NotNull] LuaParser.VarOrExpContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.var"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitVar([NotNull] LuaParser.VarContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.varSuffix"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitVarSuffix([NotNull] LuaParser.VarSuffixContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.nameAndArgs"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitNameAndArgs([NotNull] LuaParser.NameAndArgsContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.args"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitArgs([NotNull] LuaParser.ArgsContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.functiondef"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitFunctiondef([NotNull] LuaParser.FunctiondefContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.funcbody"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitFuncbody([NotNull] LuaParser.FuncbodyContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.parlist"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitParlist([NotNull] LuaParser.ParlistContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.tableconstructor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitTableconstructor([NotNull] LuaParser.TableconstructorContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.fieldlist"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitFieldlist([NotNull] LuaParser.FieldlistContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.field"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitField([NotNull] LuaParser.FieldContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.fieldsep"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitFieldsep([NotNull] LuaParser.FieldsepContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorOr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorOr([NotNull] LuaParser.OperatorOrContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorAnd"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorAnd([NotNull] LuaParser.OperatorAndContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorComparison"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorStrcat"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorAddSub"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorMulDivMod"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorBitwise"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorUnary"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.operatorPower"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitOperatorPower([NotNull] LuaParser.OperatorPowerContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.number"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitNumber([NotNull] LuaParser.NumberContext context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="LuaParser.string"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitString([NotNull] LuaParser.StringContext context);
    }
}