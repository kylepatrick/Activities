 
import { format, type DateArg } from "date-fns"

export default function formatDate(inpDate: DateArg<Date>) {
  return (
     
              format(inpDate, 'MMM dd, yyyy h:mm a')
    
    
  )
}