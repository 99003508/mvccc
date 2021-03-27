using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using CMS_DAL;

namespace CMS_BL
{
    public class FacultyBL
    {
        public List<Track> GetTracks()
        {
            List<Track> TrackList = new List<Track>();
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                TrackList = FacultyObj.GetTrackDetails();
                return TrackList;
            }
            catch (Exception ex)
            {
                return TrackList;
            }
        }

        public List<Batch> GetBatches()
        {
            List<Batch> BatchList = new List<Batch>();
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                BatchList = FacultyObj.GetBatchDetails();
                return BatchList;
            }
            catch (Exception ex)
            {
                return BatchList;
            }
        }

        public int AddTrack(Model.Track TrackObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                if (TrackObj.TrackName.Length <= 50 && TrackObj.TrackDescription.Length <= 200)
                {
                    int lst = FacultyObj.AddNewTrack(TrackObj);
                    return lst; 
                }
                else
                {
                    return -49;
                }
            }
            catch (Exception ex)
            {
                return -48;
            }
        }

        public int UpdateModuleDuration(Model.Module ModuleObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                if (ModuleObj.ModuleDuration.Length<=50)
                {
                    int lst = FacultyObj.UpdateModuleDuration(ModuleObj);
                    return lst; 
                }
                else
                {
                    return -16;
                }
            }
            catch (Exception ex)
            {
                return -17;
            }
        }

        public int UpdateModuleName(Model.Module ModuleObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                if (ModuleObj.ModuleName.Length<=50)
                {
                    int lst = FacultyObj.UpdateModuleName(ModuleObj);
                    return lst; 
                }
                else
                {
                    return -11;
                }
            }
            catch (Exception ex)
            {
                return -10;
            }
        }

        public int UpdateModuleStatus(Model.Module ModuleObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                int lst = FacultyObj.UpdateModuleStatus(ModuleObj);
                return lst;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int UpdateTrackDescription(Model.Track TrackObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                if (TrackObj.TrackDescription.Length <= 200)
                {
                    int lst = FacultyObj.UpdateTrackDescription(TrackObj);
                    return lst; 
                }
                else
                {
                    return -47;
                }
            }
            catch (Exception ex)
            {
                return -46;
            }
        }

        public int UpdateTrackDuration(Model.Track TrackObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                if (TrackObj.TrackDuration.Length<=50)
                {
                    int lst = FacultyObj.UpdateTrackDuration(TrackObj);
                    return lst; 
                }
                else
                {
                    return -45;
                }
            }
            catch (Exception ex)
            {
                return -44;
            }
        }

        public int UpdateTrackName(Model.Track TrackObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                if (TrackObj.TrackName.Length<=50)
                {
                    int lst = FacultyObj.UpdateTrackName(TrackObj);
                    return lst; 
                }
                else
                {
                    return -43;
                }
            }
            catch (Exception ex)
            {
                return -42;
            }
        }

        public int UpdateTrackStatus(Model.Track TrackObj)
        {
            try
            {
                FacultyDAL FacultyObj = new FacultyDAL();
                int lst = FacultyObj.UpdateTrackStatus(TrackObj);
                return lst;
            }
            catch (Exception ex)
            {
                return -40;
            }
        }
    }
}
