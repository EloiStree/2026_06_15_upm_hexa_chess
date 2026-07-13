using System;
using UnityEngine;

namespace Eloi.HexaChess
{
    public class HexaChessMono_RotateAroundCenterOfTarget : MonoBehaviour
    {

        public Transform m_centerAnchor;
        public Transform m_whatToMoveAround;

        public float m_rotationAroundYEuler1= 90f;
        public float m_rotationAroundXEuler2= 45f;
        public float m_zoom_distance = 1.0f;
        public Vector2 m_panelOffset = Vector2.zero;


        private void OnValidate()
        {
            RefreshPosition();
        }

        private void Awake()
        {
            RefreshPosition();
        }

        private void RefreshPosition()
        {
            if (m_centerAnchor == null || m_whatToMoveAround == null)
                return;
            m_whatToMoveAround.position = m_centerAnchor.position;
            m_whatToMoveAround.rotation = m_centerAnchor.rotation;
            m_whatToMoveAround.rotation = m_whatToMoveAround.rotation * Quaternion.Euler(0, m_rotationAroundYEuler1, 0);
            m_whatToMoveAround.rotation = m_whatToMoveAround.rotation * Quaternion.Euler(m_rotationAroundXEuler2, 0, 0);
            m_whatToMoveAround.position += -m_whatToMoveAround.forward * m_zoom_distance;
            m_whatToMoveAround.position += m_whatToMoveAround.right * m_panelOffset.x;
            m_whatToMoveAround.position += m_whatToMoveAround.up * m_panelOffset.y;

        }

        public void SetHorizontalRotation(float eulerY)
        {
            m_rotationAroundYEuler1 = eulerY;
            RefreshPosition();
        }
        public void SetVerticalRotation(float eulerX)
        {
            m_rotationAroundXEuler2 = eulerX;
            RefreshPosition();
        }
        public void SetZoomDistance(float distance)
        {
            m_zoom_distance = distance;
            RefreshPosition();
        }
        public void SetPanelOffset(Vector2 offset)
        {
            m_panelOffset = offset;
            RefreshPosition();
        }
        public void SetPanelOffsetHorizontal(float offsetX)
        {
            m_panelOffset.x = offsetX;
            RefreshPosition();
        }
        public void SetPanelOffsetVertical(float offsetY)
        {
            m_panelOffset.y = offsetY;
            RefreshPosition();
        }
    }
}
