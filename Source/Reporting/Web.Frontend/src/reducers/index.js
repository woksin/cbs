import { combineReducers } from "redux";
import dataCollectors from "./dataCollectors";
import caseReports from "./dataCollectors";

export default combineReducers({
    dataCollectors: dataCollectors(),
    caseReports : caseReports()
});
