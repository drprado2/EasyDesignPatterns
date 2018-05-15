import {actionsTypes} from '../actions/action-types';

const INITIAL_STATE={
    routesStack: ["Design Patterns"],
    actualRoute: "Design Patterns/",
    showReturnArrow: false
}

const calculateRoute = routesStack => routesStack.join('/');

const showReturnArrow = routesStack => routesStack.length > 1;

export const locationReducer = (state=INITIAL_STATE, action) => {
    switch(action.type){
        case(actionsTypes.GO_LOCATION):{
            const routesStack = state.routesStack.concat([action.newLocation]);
            const showArrow =  showReturnArrow(routesStack);
            return {...state, routesStack: routesStack, actualRoute: calculateRoute(routesStack), showReturnArrow: showArrow};
            break;
        }
        case(actionsTypes.RETURN_LOCATION):{
            const routesStack = state.routesStack.slice(0, state.routesStack.length - 1);
            const showArrow =  showReturnArrow(routesStack);
            return {...state, routesStack: routesStack, actualRoute: calculateRoute(routesStack), showReturnArrow: showArrow};
            break;
        }
        case(actionsTypes.GO_HOME):{
            const routesStack = ["Design Patterns"];
            const showArrow =  showReturnArrow(routesStack);
            return {...state, routesStack: routesStack, actualRoute: calculateRoute(routesStack), showReturnArrow: showArrow};
            break;
        }
        default: return {...state}
    }
}