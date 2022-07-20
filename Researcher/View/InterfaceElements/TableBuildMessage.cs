using MatlabBase.Types.Interfaces;
using Model.CatRef;

namespace Researcher.View.InterfaceElements
{
    public readonly struct TableBuildMessage
    {
        public TableBuildMessage(MatlabFunc targetFunc, IVariableParameter xParam, IVariableParameter yParam, double xDelta, double yDelta, double[,] funcValues, int valuesPrecision, bool buildOnInit)
        {
            TargetFunc = targetFunc;
            XParam = xParam;
            YParam = yParam;
            XDelta = xDelta;
            YDelta = yDelta;
            FuncValues = funcValues;
            ValuesPrecision = valuesPrecision;
            BuildOnInit = buildOnInit;
        }

        public MatlabFunc TargetFunc { get; init; }

        public IVariableParameter XParam { get; init; }

        public IVariableParameter YParam { get; init; }

        public double XDelta { get; init; }

        public double YDelta { get; init; }

        public double[,] FuncValues { get; init; }

        public int ValuesPrecision { get; init; } = 2;

        public bool BuildOnInit { get; init; } = true;
    }
}