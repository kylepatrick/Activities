import { createBrowserRouter } from "react-router";
import App from "../layouts/App";
 
import HomePage from "../../features/home/HomePage";
import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard";
import ActivityForm from "../../features/activities/form/ActivityForm";
 import ActivityDetailPage from "../../features/activities/details/ActivityDetailPage";


export const router= createBrowserRouter(
    [
        {
            path: '/',
            element: <App/>,
            children: 
[
{path: '',element: <HomePage/>},
{path: 'activities',element: <ActivityDashboard/>},
{path: 'createActivity',element: <ActivityForm key='create'/>},
{path: 'activities/:id',element: <ActivityDetailPage/>},
{path: 'manage/:id',element: <ActivityForm/>},
]

            
        }
    ]
)