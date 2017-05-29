// This file is part of SNMP#NET.
// 
// SNMP#NET is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// SNMP#NET is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with SNMP#NET.  If not, see <http://www.gnu.org/licenses/>.
// 

namespace SnmpSharpNet
{
    /// <summary>Helper returns error messages for SNMP v1 and v2 error codes</summary>
    /// <remarks>
    ///     Helper class provides translation of SNMP version 1 and 2 error status codes to short, descriptive
    ///     error messages.
    ///     To use, call the static member <see cref="SnmpError.ErrorMessage" />.
    ///     Example:
    ///     <code>Console.WriteLine("Agent error: {0}",SnmpError.ErrorMessage(12));</code>
    /// </remarks>
    public sealed class SnmpError
    {
        /// <summary>
        ///     Private constructor.
        /// </summary>
        private SnmpError()
        {
        }

        /// <summary>
        ///     Return SNMP version 1 and 2 error code (errorCode field in the <see cref="Pdu" /> class) as
        ///     a short, descriptive string.
        /// </summary>
        /// <param name="errorCode">Error code sent by the agent</param>
        /// <returns>Short error message for the error code</returns>
        public static string ErrorMessage(int errorCode)
        {
            if (errorCode == SnmpConstants.ErrNoError)
                return "No error";
            if (errorCode == SnmpConstants.ErrTooBig)
                return "Request too big";
            if (errorCode == SnmpConstants.ErrNoSuchName)
                return "noSuchName";
            if (errorCode == SnmpConstants.ErrBadValue)
                return "badValue";
            if (errorCode == SnmpConstants.ErrReadOnly)
                return "readOnly";
            if (errorCode == SnmpConstants.ErrGenError)
                return "genericError";
            if (errorCode == SnmpConstants.ErrNoAccess)
                return "noAccess";
            if (errorCode == SnmpConstants.ErrWrongType)
                return "wrongType";
            if (errorCode == SnmpConstants.ErrWrongLength)
                return "wrongLength";
            if (errorCode == SnmpConstants.ErrWrongEncoding)
                return "wrongEncoding";
            if (errorCode == SnmpConstants.ErrWrongValue)
                return "wrongValue";
            if (errorCode == SnmpConstants.ErrNoCreation)
                return "noCreation";
            if (errorCode == SnmpConstants.ErrInconsistentValue)
                return "inconsistentValue";
            if (errorCode == SnmpConstants.ErrResourceUnavailable)
                return "resourceUnavailable";
            if (errorCode == SnmpConstants.ErrCommitFailed)
                return "commitFailed";
            if (errorCode == SnmpConstants.ErrUndoFailed)
                return "undoFailed";
            if (errorCode == SnmpConstants.ErrAuthorizationError)
                return "authorizationError";
            if (errorCode == SnmpConstants.ErrNotWritable)
                return "notWritable";
            if (errorCode == SnmpConstants.ErrInconsistentName)
                return "inconsistentName";
            return string.Format("Unknown error ({0})", errorCode);
        }
    }
}