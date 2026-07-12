using UnityEngine;

namespace Eloi.HexaChess
{
    public class HexaChessMono_ScaleRotateAndOffset : MonoBehaviour
    {

        public Transform m_toAffect;


        private void Reset()
        {
            m_toAffect = transform;
        }

        [Range(-1.0f, 1.0f)]
        public float m_rotationPercentOnAxisY = 0.0f;
        public float m_rotationAngleMax = 360.0f;


        [Range(-1.0f, 1.0f)]
        public float m_scalePercent = 0.0f;
        public float m_scaleMin = 0.1f;
        public float m_scaleMax = 2.0f;

        public Vector3 m_localOffset = Vector3.zero;
        public float m_offsetRange = 1.0f;

        public bool m_useRandomAtAwake = true;

        private void Awake()
        {
            if (m_useRandomAtAwake)
                RandomRotationScaleOffset();
        }

        [ContextMenu("Random Rotation Scale Offset")]
        public void RandomRotationScaleOffset()
        {
            RandomOffset();
            RandomScale();
            RandomRotation();
        }

        public void RandomOffset()
        {

            m_toAffect.localPosition = new Vector3(
                Random.Range(-m_offsetRange, m_offsetRange),
                Random.Range(-m_offsetRange, m_offsetRange),
                Random.Range(-m_offsetRange, m_offsetRange)
            );
        }

        public void RandomScale()
        {
            SetScalePercent11(Random.Range(-1.0f, 1.0f));
        }
        public void RandomRotation()
        {
            SetScalePercent11(Random.Range(-1.0f, 1.0f));
        }
        public void SetRotationPercent11OnAxisY(float percent11)
        {
            m_toAffect.localRotation = Quaternion.Euler(
                0.0f,
                percent11 * m_rotationAngleMax,
                0.0f
            );

        }
        public void SetScalePercent11(float percent11)
        {
            m_toAffect.localScale = Vector3.one * Mathf.Lerp(m_scaleMin, m_scaleMax, (percent11 + 1.0f) / 2.0f);

        }
    }
}
