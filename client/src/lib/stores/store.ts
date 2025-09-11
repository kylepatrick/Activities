import { createContext } from "react";
import Counterstore from "./counterStore";
import { UiStore } from "./uiStore";

interface Store{

counterStore: Counterstore
uiStore: UiStore

}

export const store: Store={
counterStore: new Counterstore(),
uiStore: new UiStore()

}
export const StoreContext=
createContext(store);

