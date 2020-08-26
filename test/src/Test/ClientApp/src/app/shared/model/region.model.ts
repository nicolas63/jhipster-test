import { IUser } from 'app/core/user/user.model';

export interface IRegion {
  id?: number;
  regionName?: string;
  user?: IUser;
}

export class Region implements IRegion {
  constructor(public id?: number, public regionName?: string, public user?: IUser) {}
}
