using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._01_Entities
{
    public class CarInspection
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "تاریخ درخواست نمی‌تواند خالی باشد.")]
        [DataType(DataType.Date, ErrorMessage = "فرمت تاریخ نامعتبر است.")]
        public DateTime RequestDate { get; set; }

        [Required(ErrorMessage = "شماره پلاک نمی‌تواند خالی باشد.")]
        
        public string PlateNumber { get; set; }

        public CarModel? CarModel { get; set; }

        [Required(ErrorMessage = "شناسه مدل خودرو نمی‌تواند خالی باشد.")]
        public int CarModelId { get; set; }

        [Required(ErrorMessage = "کد ملی نمی‌تواند خالی باشد.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "کد ملی باید ۱۰ رقم باشد.")]
        public string OwnerNationalId { get; set; }

        [Required(ErrorMessage = "سال تولید نمی‌تواند خالی باشد.")]
        [Range(1350, 1403, ErrorMessage = "سال تولید باید بین 1350 تا 1403 باشد.")]
        public int ProductionYear { get; set; }

        [Required(ErrorMessage = "شماره تلفن نمی‌تواند خالی باشد.")]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره تلفن باید ۱۱ رقم و با 09 شروع شود.")]
        public string OwnerPhoneNumber { get; set; }

        [Required(ErrorMessage = "آدرس مالک نمی‌تواند خالی باشد.")]
        [StringLength(500, ErrorMessage = "آدرس مالک نمی‌تواند بیشتر از 500 کاراکتر باشد.")]
        public string OwnerAdress { get; set; }

        public InspectStatusEnum Status { get; set; }

        public static DateTime GetPersianDateAsDateTime(DateTime requestDate)
        {
            var persianCalendar = new System.Globalization.PersianCalendar();

           
            int year = persianCalendar.GetYear(requestDate);
            int month = persianCalendar.GetMonth(requestDate);
            int day = persianCalendar.GetDayOfMonth(requestDate);

            
            return new DateTime(year, month, day, new PersianCalendar());
        }


    }

}
