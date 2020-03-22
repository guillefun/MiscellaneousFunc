 public static void SamVaLentin<T>(this IEnumerable<T> internetMemes, Action<T> save_to_gallery){
            IEnumerator<T> daily_mims = internetMemes.GetEnumerator();
            Action daily_sam_va_lentin_memes = null;

            daily_sam_va_lentin_memes = () =>{
                if (daily_mims.MoveNext()){
                    save_to_gallery(daily_mims.Current);
                    daily_sam_va_lentin_memes();
                }
            };
            daily_sam_va_lentin_memes();
    }