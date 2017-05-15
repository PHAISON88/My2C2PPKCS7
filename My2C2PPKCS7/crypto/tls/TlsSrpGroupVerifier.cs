﻿using System;

using My2C2P.Org.BouncyCastle.Crypto.Parameters;

namespace My2C2P.Org.BouncyCastle.Crypto.Tls
{
    public interface TlsSrpGroupVerifier
    {
        /**
         * Check whether the given SRP group parameters are acceptable for use.
         * 
         * @param group the {@link SRP6GroupParameters} to check
         * @return true if (and only if) the specified group parameters are acceptable
         */
        bool Accept(Srp6GroupParameters group);
    }
}
