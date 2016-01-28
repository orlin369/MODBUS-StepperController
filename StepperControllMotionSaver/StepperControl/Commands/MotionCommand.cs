using System;

namespace StepperControl.Commands
{
    [Serializable]
    public class MotionCommand : EventArgs
    {

        #region Variables

        /// <summary>
        /// Speed in [s/sec]
        /// </summary>
        public float Speed = 0;

        /// <summary>
        /// Position [deg]
        /// </summary>
        public float Position = 0;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MotionCommand()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="steps">Steps</param>
        /// <param name="frwquency">Frequency</param>
        public MotionCommand(float position, float speed)
        {
            this.Position = position;
            this.Speed = speed;
        }

        #endregion

        #region Public

        /// <summary>
        /// Time that will be consumed for execution.
        /// </summary>
        /// <returns>Time in seconds.</returns>
        public float WaitTime()
        {
            // S = V * t
            // t = S / V
            // speed[Hz] = 1 / time
            // stepsCount / 360.0f
            // NOT GOOD!
            float stepsPerDeg = 5000.0f / 360.0f;
            float steps = this.Position * stepsPerDeg;
            float time = 1.0f / this.Speed;

            return (float)Math.Abs((time * steps) * 1000.0f);
        }

        /// <summary>
        /// Generate string descriptoin.
        /// </summary>
        /// <returns>Text</returns>
        public override string ToString()
        {
            return String.Format("Position: {0}; Speed: {1}", this.Position, this.Speed);
        }

        #endregion
    }
}
