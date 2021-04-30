using Microsoft.JSInterop;

namespace AdBrixRmWeb
{
    public class AbxCommerceCategory
    {
        private readonly IJSRuntime js;

        private string Category1 { get; set; }
        private string Category2 { get; set; }
        private string Category3 { get; set; }
        private string Category4 { get; set; }
        private string Category5 { get; set; }

        private AbxCommerceCategory(string category1, string category2, string category3, string category4,
            string category5)
        {
 
                this.Category1 = category1;
                this.Category2 = category2;
                this.Category3 = category3;
                this.Category4 = category4;
                this.Category5 = category5;
                
                js.InvokeAsync<object>("adbrix.commerceAttr.categories", category1, category2, category3, category4, category5);

                
        }
        
        private AbxCommerceCategory(string category1, string category2, string category3, string category4)
        {
 
            this.Category1 = category1;
            this.Category2 = category2;
            this.Category3 = category3;
            this.Category4 = category4;
            
            js.InvokeAsync<object>("adbrix.commerceAttr.categories", category1, category2, category3, category4);

                
        }
        
        private AbxCommerceCategory(string category1, string category2, string category3)
        {
 
            this.Category1 = category1;
            this.Category2 = category2;
            this.Category3 = category3;
            
            js.InvokeAsync<object>("adbrix.commerceAttr.categories", category1, category2, category3);

                
        }
        
        private AbxCommerceCategory(string category1, string category2)
        {
 
            this.Category1 = category1;
            this.Category2 = category2;
            
            js.InvokeAsync<object>("adbrix.commerceAttr.categories", category1, category2);

                
        }
        private AbxCommerceCategory(string category1)
        {
 
            this.Category1 = category1;

            js.InvokeAsync<object>("adbrix.commerceAttr.categories", category1);
        }
        
        

        public static AbxCommerceCategory CategoryCreate(string category1)
        {
             return new AbxCommerceCategory(category1);
        }
        
        public static AbxCommerceCategory CategoryCreate(string category1, string category2)
        {
            return new AbxCommerceCategory(category1, category2);
        }
        
        public static AbxCommerceCategory CategoryCreate(string category1, string category2, string category3)
        {
            return new AbxCommerceCategory(category1, category2, category3);
        }
        
        public static AbxCommerceCategory CategoryCreate(string category1, string category2, string category3, string category4)
        {
            return new AbxCommerceCategory(category1, category2, category3, category4);
        }
        
        public static AbxCommerceCategory CategoryCreate(string category1, string category2, string category3, string category4, string category5)
        {
            return new AbxCommerceCategory(category1, category2, category3, category4, category5);
        }
        
    }
}