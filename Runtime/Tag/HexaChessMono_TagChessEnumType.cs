
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.HexaChess
{
    public class HexaChessMono_TagChessEnumType : MonoBehaviour
    {

        public static List<HexaChessMono_TagChessEnumType> m_instanceInScene = new List<HexaChessMono_TagChessEnumType>();

        public void OnEnable()
        {
            m_instanceInScene.Add(this);
        }
        public void OnDisable()
        {
            m_instanceInScene.Remove(this);
        }

        public HexaChessEnumColor m_chessColor = HexaChessEnumColor.Undefined;
        public HexaChessEnumType m_chessType = HexaChessEnumType.Undefined;

        public void SetType(HexaChessEnumType type)
        {
            m_chessType = type;
        }
        public void SetColor(HexaChessEnumColor color)
        {
            m_chessColor = color;
        }
        public HexaChessEnumType GetChessType
            ()
        {
            return m_chessType;
        }
        public HexaChessEnumColor GetChessColor()
        {
            return m_chessColor;
        }

        public bool IsWhiteColor()
        {
            return m_chessColor == HexaChessEnumColor.White;
        }
        public bool IsBlackColor()
        {
            return m_chessColor == HexaChessEnumColor.Black;
        }
        public bool IsPawnType()
        {
            return m_chessType == HexaChessEnumType.Pawn;
        }
        public bool IsRookType()
        {
            return m_chessType == HexaChessEnumType.Rook;
        }
        public bool IsKnightType()
        {
            return m_chessType == HexaChessEnumType.Knight;
        }
        public bool IsBishopType()
        {
            return m_chessType == HexaChessEnumType.Bishop;
        }   
        public bool IsQueenType()
        {
            return m_chessType == HexaChessEnumType.Queen;
        }
        public bool IsKingType()
        {
            return m_chessType == HexaChessEnumType.King;
        }
    }
}
