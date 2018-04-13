﻿//    This file is part of Nfield.SDK.
//
//    Nfield.SDK is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Nfield.SDK is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with Nfield.SDK.  If not, see <http://www.gnu.org/licenses/>.

using System;
using Nfield.Services;
using Nfield.Services.Implementation;
using Nfield.Utilities;

namespace Nfield.Infrastructure
{
    /// <summary>
    /// Used to register the types into the user-defined IoC container.
    /// </summary>
    public static class NfieldSdkInitializer
    {
        /// <summary>
        /// Method that registers all known types by calling the delegates provided.
        /// This method must be called before using the SDK.
        /// </summary>
        /// <param name="registerTransient">Method that registers a Transient type.</param>
        /// <param name="registerSingleton">Method that registers a Singleton.</param>
        /// <param name="registerInstance">Method that registers an instance.</param>
        public static void Initialize(Action<Type, Type> registerTransient, 
                                      Action<Type, Type> registerSingleton,
                                      Action<Type, Object> registerInstance)
        {
            registerTransient(typeof(NfieldConnection), typeof(NfieldConnection));
            registerTransient(typeof(INfieldInterviewersService), typeof(NfieldInterviewersService));
            registerTransient(typeof(INfieldInterviewQualityService), typeof(NfieldInterviewQualityService));
            registerTransient(typeof(INfieldSurveysService), typeof(NfieldSurveysService));
            registerTransient(typeof(INfieldRespondentDataEncryptService), typeof(NfieldRespondentDataEncryptService));
            registerTransient(typeof(INfieldSurveyDataService), typeof(NfieldSurveyDataService));
            registerTransient(typeof(INfieldBackgroundTasksService), typeof(NfieldBackgroundTasksService));
            registerTransient(typeof(INfieldSurveyScriptService), typeof(NfieldSurveyScriptService));
            registerTransient(typeof(INfieldSurveyScriptFragmentService), typeof(NfieldSurveyScriptFragmentService));
            registerTransient(typeof(INfieldFieldworkOfficesService), typeof(NfieldFieldworkOfficesService));
            registerTransient(typeof(INfieldMediaFilesService), typeof(NfieldMediaFilesService));
            registerTransient(typeof(INfieldLanguagesService), typeof(NfieldLanguagesService));
            registerTransient(typeof(INfieldTranslationsService), typeof(NfieldTranslationsService));
            registerTransient(typeof(INfieldDomainEmailSettingsService), typeof(NfieldDomainEmailSettingsService));
            registerTransient(typeof(INfieldSurveyEmailSettingsService), typeof(NfieldSurveyEmailSettingsService));
            registerTransient(typeof(INfieldSurveyInvitationImagesService), typeof(NfieldSurveyInvitationImagesService));
            registerTransient(typeof(INfieldSurveyInvitationTemplatesService), typeof(NfieldSurveyInvitationTemplatesService)); 
            registerTransient(typeof(INfieldSurveySettingsService), typeof(NfieldSurveySettingsService));
            registerTransient(typeof(INfieldSurveyResponseCodesService), typeof(NfieldSurveyResponseCodesService));
            registerTransient(typeof(INfieldSurveyRelocationsService), typeof(NfieldSurveyRelocationsService));
            registerTransient(typeof(INfieldSurveyPublicIdsService), typeof(NfieldSurveyPublicIdsService));
            registerTransient(typeof(INfieldSurveyInterviewersService), typeof(NfieldSurveyInterviewersService));
            registerTransient(typeof(INfieldSamplingPointInterviewerAssignmentsService), typeof(NfieldSamplingPointInterviewerAssignmentsService));
            registerTransient(typeof(INfieldSurveyInterviewerAssignmentsService), typeof(NfieldSurveyInterviewerAssignmentsService));
            registerTransient(typeof(INfieldSurveyInterviewerWorkpackageDistributionService), typeof(NfieldSurveyInterviewerWorkpackageDistributionService));
            registerTransient(typeof(INfieldSurveyFieldworkService), typeof(NfieldSurveyFieldworkService));
            registerTransient(typeof(INfieldAddressesService), typeof(NfieldAddressesService));
            registerTransient(typeof(INfieldSurveyPackageService), typeof(NfieldSurveyPackageService));
            registerTransient(typeof(INfieldSurveyPublishService), typeof(NfieldSurveyPublishService));
            registerTransient(typeof(INfieldSurveySampleDataService), typeof(NfieldSurveySampleDataService));
            registerTransient(typeof(INfieldSurveySampleService), typeof(NfieldSurveySampleService));
            registerTransient(typeof(INfieldHttpClient), typeof(NfieldHttpClient));
            registerTransient(typeof(IFileSystem), typeof(FileSystem));
            registerTransient(typeof(INfieldEncryptionUtility), typeof(NfieldEncryptionUtility));
            registerTransient(typeof(IAesManagedWrapper), typeof(AesManagedWrapper));
            registerTransient(typeof(INfieldSurveyInviteRespondentsService), typeof(NfieldSurveyInviteRespondentsService));
            registerTransient(typeof(INfieldSurveyVarFileService), typeof(NfieldSurveyVarFileService));
            registerTransient(typeof(INfieldRespondentSurveysService), typeof(NfieldRespondentSurveysService));
        }

    }
}