using System;

using My2C2P.Org.BouncyCastle.Security;

namespace My2C2P.Org.BouncyCastle.Crypto.Parameters
{
    public class DHKeyGenerationParameters
		: KeyGenerationParameters
    {
        private readonly DHParameters parameters;

		public DHKeyGenerationParameters(
            SecureRandom	random,
            DHParameters	parameters)
			: base(random, GetStrength(parameters))
        {
            this.parameters = parameters;
        }

		public DHParameters Parameters
        {
            get { return parameters; }
        }

		internal static int GetStrength(
			DHParameters parameters)
		{
			return parameters.L != 0 ? parameters.L : parameters.P.BitLength;
		}
    }
}
