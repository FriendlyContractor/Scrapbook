using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapbook.Model
{
    class PostageStamp
    {
        /// <summary>
        /// Database id used by Entity Framework
        /// </summary>
        private int Id {  get; set; }
        /// <summary>
        /// Name of the stamp
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Theme of the stamp. Example: "Trains" or "WW2"
        /// <see cref="StampTheme"/>
        /// </summary>
        public StampTheme Theme { get; set; }
        /// <summary>
        /// Series this stamp belongs to. Example: "500 years of reformation"
        /// <see cref="StampSeries"/>
        /// </summary>
        public StampSeries Series { get; set; }
        /// <summary>
        /// Year this stamp was issued.
        /// </summary>
        /// <remarks>
        /// Stored as simple unsigned integer
        /// </remarks>
        public uint IssuedDate { get; set; }
        /// <summary>
        /// Country stamp was issued
        /// </summary>
        public Country IssuedCountry { get; set; }
        /// <summary>
        /// Any additional description of the stamp
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Whether stamp has sheet. Known as "arkusik"
        /// </summary>
        public required bool HasSheet { get; set; }
        /// <summary>
        /// Whether stamp has hinge. Know as "podlepka"
        /// </summary>
        public required bool HasHinge { get; set; }
        /// <summary>
        /// Condition of the stamp.
        /// <see cref="StampCondition"/>
        /// </summary>
        public required StampCondition Condition { get; set; }
        /// <summary>
        /// Type of perforation if any.
        /// <see cref="StampPerforation"/>
        /// </summary>
        public required StampPerforation Perforation { get; set; }
        /// <summary>
        /// Michaels catalog number.
        /// <see cref="MichaelCatalogNumber"/>
        /// </summary>
        public MichaelCatalogNumber CatalogNumber { get; set; }
    }
    /// <summary>
    /// Type of postage stamp perforation.
    /// </summary>
    public enum StampPerforation
    {
        None, Line, Comb, Harrow
    }
    /// <summary>
    /// Postage stamp's condition.
    /// </summary>
    public enum StampCondition
    {
        Mint, Unused, Used, FiscallyUsed
    }
}
