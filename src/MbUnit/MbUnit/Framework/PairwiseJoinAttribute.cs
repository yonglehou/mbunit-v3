// Copyright 2005-2008 Gallio Project - http://www.gallio.org/
// Portions Copyright 2000-2004 Jonathan De Halleux, Jamie Cansdale
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Gallio.Framework.Data;

namespace MbUnit.Framework
{
    /// <summary>
    /// <para>
    /// Sets the join strategy of a test to be pairwise.
    /// </para>
    /// <para>
    /// The test will be executed using values drawn from each data source and combined so
    /// that at most two values differ between each combitation produced.  This constraint vastly
    /// reduces the number of combinations tested while still providing a high degree of
    /// variability among combinations.  Therefore this strategy has a high likelihood of
    /// finding bugs while incurring less cost.
    /// </para>
    /// <para>
    /// If there are three data sources, A, B and C with values A1, A2, B1, B2, C1 and C2 then
    /// the test will be run three times with inputs: (A1, B1, C1), (A2, B2, C1), (A1, B2, C2).
    /// Compare this with the eight times that a standard cross-product combinatorial join
    /// strategy would have required.
    /// </para>
    /// </summary>
    /// <seealso cref="PairwiseJoinStrategy"/>
    /// <seealso cref="SequentialJoinAttribute"/>
    /// <seealso cref="CombinatorialJoinAttribute"/>
    public class PairwiseJoinAttribute : JoinAttribute
    {
        /// <inheritdoc />
        protected override IJoinStrategy GetJoinStrategy()
        {
            return PairwiseJoinStrategy.Instance;
        }
    }
}