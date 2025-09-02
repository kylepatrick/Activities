import { Grid } from "@mui/material";
import ActivityList from "./ActivityList";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";

type Props={
    activities: Activity[];
    selectActivity: (id: string)=>void;
    cancelSelectActivity: () =>void;
    selectedActivity?: Activity;
    openForm: (id: string)=>void;
    closeForm: ()=> void;
    editMode: boolean;
    submitForm: (activity: Activity)=>void;
    deleteActivity: (id:string) =>void;

}

export default function ActivityDashboard({deleteActivity,submitForm,openForm,closeForm,editMode,activities,cancelSelectActivity,selectActivity,selectedActivity}: Props) {
  return (
    <Grid container spacing={3}>
<Grid size={7}>
<ActivityList activities={activities}
selectActivity={selectActivity}
deleteActivity={deleteActivity}
/>

</Grid>
<Grid size={5}>
{selectedActivity && !editMode && <ActivityDetails 
activity={selectedActivity}
cancelSelectActivity={cancelSelectActivity}
openForm={openForm}

/>}
{editMode &&
<ActivityForm submitForm={submitForm} closeForm={closeForm} activity={selectedActivity}/>
}


</Grid>
    </Grid>
  )
}