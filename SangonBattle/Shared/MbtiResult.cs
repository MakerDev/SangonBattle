using System;
using System.Collections.Generic;
using System.Text;

namespace SangonBattle.Shared
{
    public class MbtiResult
    {
        public static MbtiResult Default { get; } =
            new MbtiResult(MbtiType.E, MbtiType.N, MbtiType.T, MbtiType.P);

        public MbtiType M { get; set; }
        public MbtiType B { get; set; }
        public MbtiType T { get; set; }
        public MbtiType I { get; set; }



        /// <summary>
        /// This is for Json Deserialization
        /// </summary>
        public MbtiResult()
        {

        }

        public MbtiResult(string mbti)
        {
            M = (MbtiType)Enum.Parse(typeof(MbtiType), mbti[0].ToString(), true); 
            B = (MbtiType)Enum.Parse(typeof(MbtiType), mbti[1].ToString(), true); 
            T = (MbtiType)Enum.Parse(typeof(MbtiType), mbti[2].ToString(), true); 
            I = (MbtiType)Enum.Parse(typeof(MbtiType), mbti[3].ToString(), true); 
        }

        public MbtiResult(MbtiType m, MbtiType b, MbtiType t, MbtiType i)
        {
            M = m;
            B = b;
            T = t;
            I = i;
        }

        public MbtiResult(int m, int b, int t, int i)
        {
            M = m >= 0 ? MbtiType.I : MbtiType.E;
            B = b >= 0 ? MbtiType.N : MbtiType.S;
            T = t >= 0 ? MbtiType.F : MbtiType.T;
            I = i >= 0 ? MbtiType.P : MbtiType.J;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var objCasted = obj as MbtiResult;

            if (objCasted.M == M
                && objCasted.B == B
                && objCasted.T == T
                && objCasted.I == I)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return (M.ToString() + B.ToString() + T.ToString() + I.ToString());
        }

        public MbtiResult GetOpposite()
        {
            return new MbtiResult(GetOppositeType(M),
                                  GetOppositeType(B),
                                  GetOppositeType(T),
                                  GetOppositeType(I));
        }

        public static MbtiType GetOppositeType(MbtiType mbtiType)
        {
            switch (mbtiType)
            {
                case MbtiType.I:
                    return MbtiType.E;
                case MbtiType.E:
                    return MbtiType.I;
                case MbtiType.N:
                    return MbtiType.S;
                case MbtiType.S:
                    return MbtiType.N;
                case MbtiType.F:
                    return MbtiType.T;
                case MbtiType.T:
                    return MbtiType.F;
                case MbtiType.P:
                    return MbtiType.J;
                case MbtiType.J:
                    return MbtiType.P;
                default:
                    break;
            }

            return MbtiType.E;
        }
    }
}
